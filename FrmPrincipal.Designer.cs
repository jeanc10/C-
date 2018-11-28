namespace Dashboard_Dying
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.btnFormularios = new DevExpress.XtraBars.BarButtonItem();
            this.btnRoles = new DevExpress.XtraBars.BarButtonItem();
            this.btnUsuarioRoles = new DevExpress.XtraBars.BarButtonItem();
            this.btnPemisos = new DevExpress.XtraBars.BarButtonItem();
            this.BSIPlanta = new DevExpress.XtraBars.BarStaticItem();
            this.btnKPI = new DevExpress.XtraBars.BarButtonItem();
            this.BSIUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.skin = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnSeteoMetas = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegistroCumplimientos = new DevExpress.XtraBars.BarButtonItem();
            this.btnPeriocidades = new DevExpress.XtraBars.BarButtonItem();
            this.btnUnidadesMedida = new DevExpress.XtraBars.BarButtonItem();
            this.btnClasificacion = new DevExpress.XtraBars.BarButtonItem();
            this.FrmReporte = new DevExpress.XtraBars.BarButtonItem();
            this.btnDashnoard = new DevExpress.XtraBars.BarCheckItem();
            this.btnDashboardConfig = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.dSLogin = new Dashboard_Dying.DSLogin();
            this.sEG_USUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sEG_USUARIOSTableAdapter = new Dashboard_Dying.DSLoginTableAdapters.SEG_USUARIOSTableAdapter();
            this.tableAdapterManager = new Dashboard_Dying.DSLoginTableAdapters.TableAdapterManager();
            this.splshCargando = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Dashboard_Dying.FrmCargando), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEG_USUARIOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnUsuarios,
            this.btnFormularios,
            this.btnRoles,
            this.btnUsuarioRoles,
            this.btnPemisos,
            this.BSIPlanta,
            this.btnKPI,
            this.BSIUsuario,
            this.skin,
            this.btnSeteoMetas,
            this.btnRegistroCumplimientos,
            this.btnPeriocidades,
            this.btnUnidadesMedida,
            this.btnClasificacion,
            this.FrmReporte,
            this.btnDashnoard,
            this.btnDashboardConfig,
            this.barButtonItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 20;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.BSIPlanta);
            this.ribbonControl1.PageHeaderItemLinks.Add(this.BSIUsuario);
            this.ribbonControl1.PageHeaderItemLinks.Add(this.skin);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage3,
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(811, 146);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Caption = "Usuarios";
            this.btnUsuarios.Id = 1;
            this.btnUsuarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.ImageOptions.Image")));
            this.btnUsuarios.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.ImageOptions.LargeImage")));
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsuarios_ItemClick);
            // 
            // btnFormularios
            // 
            this.btnFormularios.Caption = "Formularios";
            this.btnFormularios.Id = 2;
            this.btnFormularios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFormularios.ImageOptions.Image")));
            this.btnFormularios.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFormularios.ImageOptions.LargeImage")));
            this.btnFormularios.Name = "btnFormularios";
            this.btnFormularios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFormularios_ItemClick);
            // 
            // btnRoles
            // 
            this.btnRoles.Caption = "Roles";
            this.btnRoles.Id = 3;
            this.btnRoles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRoles.ImageOptions.Image")));
            this.btnRoles.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRoles.ImageOptions.LargeImage")));
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRoles_ItemClick);
            // 
            // btnUsuarioRoles
            // 
            this.btnUsuarioRoles.Caption = "Usuario Roles";
            this.btnUsuarioRoles.Id = 4;
            this.btnUsuarioRoles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarioRoles.ImageOptions.Image")));
            this.btnUsuarioRoles.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUsuarioRoles.ImageOptions.LargeImage")));
            this.btnUsuarioRoles.Name = "btnUsuarioRoles";
            this.btnUsuarioRoles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsuarioRoles_ItemClick);
            // 
            // btnPemisos
            // 
            this.btnPemisos.Caption = "Pemisos";
            this.btnPemisos.Id = 5;
            this.btnPemisos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPemisos.ImageOptions.Image")));
            this.btnPemisos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPemisos.ImageOptions.LargeImage")));
            this.btnPemisos.Name = "btnPemisos";
            this.btnPemisos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPemisos_ItemClick);
            // 
            // BSIPlanta
            // 
            this.BSIPlanta.Id = 6;
            this.BSIPlanta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BSIPlanta.ImageOptions.Image")));
            this.BSIPlanta.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BSIPlanta.ImageOptions.LargeImage")));
            this.BSIPlanta.Name = "BSIPlanta";
            this.BSIPlanta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BSIPlanta_ItemClick);
            // 
            // btnKPI
            // 
            this.btnKPI.Caption = "Tipos de KPI";
            this.btnKPI.Id = 7;
            this.btnKPI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKPI.ImageOptions.Image")));
            this.btnKPI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKPI.ImageOptions.LargeImage")));
            this.btnKPI.Name = "btnKPI";
            this.btnKPI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKPI_ItemClick);
            // 
            // BSIUsuario
            // 
            this.BSIUsuario.Id = 8;
            this.BSIUsuario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BSIUsuario.ImageOptions.Image")));
            this.BSIUsuario.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BSIUsuario.ImageOptions.LargeImage")));
            this.BSIUsuario.Name = "BSIUsuario";
            // 
            // skin
            // 
            this.skin.Caption = "skinRibbonGalleryBarItem1";
            this.skin.Id = 9;
            this.skin.Name = "skin";
            // 
            // btnSeteoMetas
            // 
            this.btnSeteoMetas.Caption = "Seteo Metas";
            this.btnSeteoMetas.Id = 10;
            this.btnSeteoMetas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeteoMetas.ImageOptions.Image")));
            this.btnSeteoMetas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSeteoMetas.ImageOptions.LargeImage")));
            this.btnSeteoMetas.Name = "btnSeteoMetas";
            this.btnSeteoMetas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSeteoMetas_ItemClick);
            // 
            // btnRegistroCumplimientos
            // 
            this.btnRegistroCumplimientos.Caption = "Registro Cumplimientos";
            this.btnRegistroCumplimientos.Id = 11;
            this.btnRegistroCumplimientos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistroCumplimientos.ImageOptions.Image")));
            this.btnRegistroCumplimientos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRegistroCumplimientos.ImageOptions.LargeImage")));
            this.btnRegistroCumplimientos.Name = "btnRegistroCumplimientos";
            this.btnRegistroCumplimientos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRegistroCumplimientos_ItemClick);
            // 
            // btnPeriocidades
            // 
            this.btnPeriocidades.Caption = "Periocidades";
            this.btnPeriocidades.Id = 12;
            this.btnPeriocidades.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPeriocidades.ImageOptions.Image")));
            this.btnPeriocidades.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPeriocidades.ImageOptions.LargeImage")));
            this.btnPeriocidades.Name = "btnPeriocidades";
            this.btnPeriocidades.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPeriocidades_ItemClick);
            // 
            // btnUnidadesMedida
            // 
            this.btnUnidadesMedida.Caption = "Unidades de Medida";
            this.btnUnidadesMedida.Id = 13;
            this.btnUnidadesMedida.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUnidadesMedida.ImageOptions.Image")));
            this.btnUnidadesMedida.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUnidadesMedida.ImageOptions.LargeImage")));
            this.btnUnidadesMedida.Name = "btnUnidadesMedida";
            this.btnUnidadesMedida.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUnidadesMedida_ItemClick);
            // 
            // btnClasificacion
            // 
            this.btnClasificacion.Caption = "Clasificación KPI\'s";
            this.btnClasificacion.Id = 15;
            this.btnClasificacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClasificacion.ImageOptions.Image")));
            this.btnClasificacion.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClasificacion.ImageOptions.LargeImage")));
            this.btnClasificacion.Name = "btnClasificacion";
            this.btnClasificacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClasificacion_ItemClick);
            // 
            // FrmReporte
            // 
            this.FrmReporte.Caption = "Reporte (Cálculos)";
            this.FrmReporte.Id = 16;
            this.FrmReporte.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmReporte.ImageOptions.Image")));
            this.FrmReporte.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmReporte.ImageOptions.LargeImage")));
            this.FrmReporte.Name = "FrmReporte";
            this.FrmReporte.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FrmReporte_ItemClick);
            // 
            // btnDashnoard
            // 
            this.btnDashnoard.Caption = "Dashboard";
            this.btnDashnoard.Id = 17;
            this.btnDashnoard.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDashnoard.ImageOptions.Image")));
            this.btnDashnoard.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDashnoard.ImageOptions.LargeImage")));
            this.btnDashnoard.Name = "btnDashnoard";
            this.btnDashnoard.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDashnoard_CheckedChanged);
            // 
            // btnDashboardConfig
            // 
            this.btnDashboardConfig.Caption = "Configuración Dashboard";
            this.btnDashboardConfig.Id = 18;
            this.btnDashboardConfig.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboardConfig.ImageOptions.Image")));
            this.btnDashboardConfig.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDashboardConfig.ImageOptions.LargeImage")));
            this.btnDashboardConfig.Name = "btnDashboardConfig";
            this.btnDashboardConfig.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDashboardConfig.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDashboardConfig_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Asignación Kpi\'s";
            this.barButtonItem1.Id = 19;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Reportes";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.FrmReporte);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDashnoard);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Carga de Información";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKPI);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSeteoMetas);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnRegistroCumplimientos);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnPeriocidades);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUnidadesMedida);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnClasificacion);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribbonPage1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Configuración";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUsuarios);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFormularios);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRoles);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUsuarioRoles);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPemisos);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Accesos";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDashboardConfig);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Dashboard";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // dSLogin
            // 
            this.dSLogin.DataSetName = "DSLogin";
            this.dSLogin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sEG_USUARIOSBindingSource
            // 
            this.sEG_USUARIOSBindingSource.DataMember = "SEG_USUARIOS";
            this.sEG_USUARIOSBindingSource.DataSource = this.dSLogin;
            // 
            // sEG_USUARIOSTableAdapter
            // 
            this.sEG_USUARIOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SEG_FORMULARIOSTableAdapter = null;
            this.tableAdapterManager.SEG_PERMISOTableAdapter = null;
            this.tableAdapterManager.SEG_PLANTASTableAdapter = null;
            this.tableAdapterManager.SEG_ROLES_PERMISOSTableAdapter = null;
            this.tableAdapterManager.SEG_ROLESTableAdapter = null;
            this.tableAdapterManager.SEG_USUARIO_ROLESTableAdapter = null;
            this.tableAdapterManager.SEG_USUARIOSTableAdapter = this.sEG_USUARIOSTableAdapter;
            this.tableAdapterManager.UpdateOrder = Dashboard_Dying.DSLoginTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // splshCargando
            // 
            this.splshCargando.ClosingDelay = 500;
            // 
            // FrmPrincipal
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 497);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sEG_USUARIOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnUsuarios;
        private DevExpress.XtraBars.BarButtonItem btnFormularios;
        private DevExpress.XtraBars.BarButtonItem btnRoles;
        private DevExpress.XtraBars.BarButtonItem btnUsuarioRoles;
        private DevExpress.XtraBars.BarButtonItem btnPemisos;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarStaticItem BSIPlanta;
        private DevExpress.XtraBars.BarButtonItem btnKPI;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarStaticItem BSIUsuario;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skin;
        private System.Windows.Forms.BindingSource sEG_USUARIOSBindingSource;
        private DSLogin dSLogin;
        private DSLoginTableAdapters.SEG_USUARIOSTableAdapter sEG_USUARIOSTableAdapter;
        private DSLoginTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarButtonItem btnSeteoMetas;
        private DevExpress.XtraBars.BarButtonItem btnRegistroCumplimientos;
        private DevExpress.XtraBars.BarButtonItem btnPeriocidades;
        private DevExpress.XtraBars.BarButtonItem btnUnidadesMedida;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnClasificacion;
        private DevExpress.XtraBars.BarButtonItem FrmReporte;
        private DevExpress.XtraBars.BarCheckItem btnDashnoard;
        private DevExpress.XtraBars.BarButtonItem btnDashboardConfig;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraSplashScreen.SplashScreenManager splshCargando;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}

