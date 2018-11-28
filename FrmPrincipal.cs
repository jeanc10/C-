using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dashboard_Dying.Pantallas;
using DevExpress.XtraEditors;
using Dashboard_Dying.KC;
using DevExpress.LookAndFeel;
using Dashboard_Dying.Dashboards;

namespace Dashboard_Dying
{
    public partial class FrmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public static FrmPrincipal vfrmPrincipal;
        int iTodasPlantas;
        string sAplicativo = "SDASH";
        string sUsuario;
        public FrmPrincipal()
        {
            InitializeComponent();
            vfrmPrincipal = this;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(Properties.Settings.Default.skinName.ToString());
            sUsuario = KC.Conexion.UsuarioDominio();
            Properties.Settings.Default.usuario = Properties.Settings.Default.Dominio + sUsuario;
            this.BSIUsuario.Caption = KC.Conexion.UsuarioDominio();
            Properties.Settings.Default.UsuarioDominio = this.BSIUsuario.Caption;
            Properties.Settings.Default.clave = "";
            Properties.Settings.Default.PlantaAsignada = "";
            Properties.Settings.Default.Save();

            try
            {
                if (KC.Conexion.logon() != true)
                {
                    Properties.Settings.Default.usuario = "";
                    Properties.Settings.Default.clave = "";
                    Properties.Settings.Default.Save();
                    Cursor = Cursors.WaitCursor;
                    this.xtraTabbedMdiManager1.MdiParent = null;
                    FrmLogin frm = new FrmLogin();
                    frm.MdiParent = this;
                    frm.Show();
                }
                //else
                //    this.LlamarSelecciondePlantas();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Default;
        }

        private void MostrarPantalla(Form form, bool mdiChild = true, bool OnlyOne = true)
        {
            try
            {
                MostrarCargando(true);
                int Accesos = 0;
                string VGU = "PRINCIPAL";
                if (Properties.Settings.Default.IsAdmin == false)
                {
                    Accesos = KC.Conexion.ACCESOSUSUARIOS(form.Name, Properties.Settings.Default.UsuarioID.ToString());
                    if (Accesos == 0)
                    {
                        VGU = "xPRINCIPAL";//Conexion.Conexion.GrupoUsuario(this.BSIUsuario.Caption);
                    }
                }
                try
                {
                    if (VGU == "PRINCIPAL" || VGU.Contains("PAYR"))
                    {
                        this.ShowForm(form, mdiChild, OnlyOne);
                    }
                    else
                    {
                        mensajeError();
                    }
                }
                catch
                {
                    mensajeError();
                }
            }
            catch (Exception ex)
            {
                Funciones.fCreateBitacora(ex.Message.ToString(), this.Text, "MostrarPantalla");
            }
            finally
            {
                MostrarCargando(false);
            }
        }

        public void ShowForm(Form pfrm, bool isMdiChid, bool Onlyone)
        {
            if (Onlyone)
            {

                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == pfrm.Name)
                    {
                        if (frm.WindowState != FormWindowState.Normal)
                        {
                            frm.WindowState = FormWindowState.Normal;
                        }
                        frm.Activate();
                        return;
                    }
                }
            }
            if (isMdiChid)
            {
                pfrm.MdiParent = this;
            }
            pfrm.Show();
        }

        public void ConfiguracionLogin()
        {
            xtraTabbedMdiManager1.MdiParent = this;
        }

        private void mensajeError()
        {
            MostrarCargando(false);
            XtraMessageBox.Show("No tiene acceso a ver esta Pantalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUsuarios FrmUsuario = new FrmUsuarios();
            MostrarPantalla(FrmUsuario);
        }

        public void LlamarSelecciondePlantas()
        {
            iTodasPlantas = Convert.ToInt32(this.sEG_USUARIOSTableAdapter.getTodasPlantas(sAplicativo, sUsuario));
            if (iTodasPlantas == 0)
            {
                Dashboard_Dying.Login.FrmSelecPlanta frmplantas = new Dashboard_Dying.Login.FrmSelecPlanta();
                frmplantas.ShowDialog();
            }
            else
            {
                Dashboard_Dying.Properties.Settings.Default.PlantaAsignada = "GILDAN";
                Dashboard_Dying.Properties.Settings.Default.NombrePlanta = "GILDAN";
                Properties.Settings.Default.Save();
                this.setPlanta();
            }
        }

        public void setPlanta()
        {
            this.BSIPlanta.Caption = Dashboard_Dying.Properties.Settings.Default.NombrePlanta;
        }

        private void btnFormularios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPantallas FrmPantalla = new FrmPantallas();
            MostrarPantalla(FrmPantalla);
        }

        private void btnRoles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRoles FrmRole = new FrmRoles();
            MostrarPantalla(FrmRole);
        }

        private void btnUsuarioRoles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUsuarioRoles FrmUsuarioRole = new FrmUsuarioRoles();
            MostrarPantalla(FrmUsuarioRole);
        }

        private void btnPemisos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAccesos FrmAcceso = new FrmAccesos();
            MostrarPantalla(FrmAcceso);
        }

        private void btnKPI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmKPI FrmKPIS = new FrmKPI();
            MostrarPantalla(FrmKPIS);
        }

        private void BSIPlanta_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                KC.Conexion.Limpiar();
                int iCount = Convert.ToInt32(this.xtraTabbedMdiManager1.MdiParent.MdiChildren.Count());
                iTodasPlantas = Convert.ToInt32(this.sEG_USUARIOSTableAdapter.getTodasPlantas(sAplicativo, sUsuario));
                if (iTodasPlantas == 0)
                {
                    for (int i = 0; i <= iCount; i++)
                    {
                        Form activeChild = this.ActiveMdiChild;
                        if (activeChild != null)
                            this.ActiveMdiChild.Close();
                    }
                    Dashboard_Dying.Login.FrmSelecPlanta frm = new Dashboard_Dying.Login.FrmSelecPlanta();
                    frm.ShowDialog();
                }
                else
                    this.LlamarSelecciondePlantas();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.skinName = UserLookAndFeel.Default.ActiveSkinName;
            Properties.Settings.Default.Save();
        }

        private void btnSeteoMetas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSeteoMetas FrmSeteoMeta = new FrmSeteoMetas();
            MostrarPantalla(FrmSeteoMeta);
        }

        private void btnRegistroCumplimientos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmRegistroCumplimiento FrmRegistroCumplimientos = new FrmRegistroCumplimiento();
            MostrarPantalla(FrmRegistroCumplimientos);
        }

        private void btnPeriocidades_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmPeriocidades FrmPeriocidad = new FrmPeriocidades();
            MostrarPantalla(FrmPeriocidad);
        }

        private void btnUnidadesMedida_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUnidadesMedida FrmUnidadMedida = new FrmUnidadesMedida();
            MostrarPantalla(FrmUnidadMedida);
        }


        private void btnClasificacion_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmClasificacionKPI FrmClasificacionKPIs = new FrmClasificacionKPI();
            MostrarPantalla(FrmClasificacionKPIs);
        }

        private void FrmReporte_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmReporte FrmReportes = new FrmReporte();
            MostrarPantalla(FrmReportes);
        }

        private void btnDashnoard_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDashboardViewer FrmDashboardViewers = new FrmDashboardViewer();
            MostrarPantalla(FrmDashboardViewers, true, false);
        }

        private void btnDashboardConfig_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Dashboard_KPI dash = new Dashboard_KPI();
            FrmDashboard FrmDashboards = new FrmDashboard(dash);
            MostrarPantalla(FrmDashboards);
        }

        public void MostrarCargando(Boolean mostrar)
        {
            if (mostrar)
            {
                if (!splshCargando.IsSplashFormVisible)
                {
                    splshCargando.ShowWaitForm();
                }
            }
            else
            {
                if (splshCargando.IsSplashFormVisible)
                {
                    splshCargando.CloseWaitForm();
                }
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUsuariosKpi tmpForm = new FrmUsuariosKpi();
            MostrarPantalla(tmpForm);
        }

    }
}
