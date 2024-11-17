namespace Project_03_Media_Player_C_Sharp_28_06_24
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.indicator = new Bunifu.UI.WinForms.BunifuShapes();
            this.line = new Bunifu.UI.WinForms.BunifuShapes();
            this.btnPlaylist = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnAlbum = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNowPlaying = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.toppanel = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.songTitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.bottompanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.soundSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btnPrev = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPlay = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnPause = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btnNext = new Bunifu.UI.WinForms.BunifuImageButton();
            this.songSlider = new Bunifu.UI.WinForms.BunifuHSlider();
            this.bunifuPages1 = new Bunifu.UI.WinForms.BunifuPages();
            this.nowPlayingTab = new System.Windows.Forms.TabPage();
            this.btnAddSong = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.albumTab = new System.Windows.Forms.TabPage();
            this.playlistTab = new System.Windows.Forms.TabPage();
            this.playlistTable = new System.Windows.Forms.TableLayoutPanel();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.toppanel.SuspendLayout();
            this.bottompanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuPages1.SuspendLayout();
            this.nowPlayingTab.SuspendLayout();
            this.bunifuShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.playlistTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(205)))));
            this.sidePanel.Controls.Add(this.bunifuPictureBox1);
            this.sidePanel.Controls.Add(this.indicator);
            this.sidePanel.Controls.Add(this.line);
            this.sidePanel.Controls.Add(this.btnPlaylist);
            this.sidePanel.Controls.Add(this.btnAlbum);
            this.sidePanel.Controls.Add(this.btnNowPlaying);
            this.sidePanel.Controls.Add(this.bunifuLabel1);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(228, 636);
            this.sidePanel.TabIndex = 0;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 51;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(53, 12);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(103, 103);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 5;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // indicator
            // 
            this.indicator.Angle = 0F;
            this.indicator.BackColor = System.Drawing.Color.Transparent;
            this.indicator.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.indicator.BorderThickness = 2;
            this.indicator.FillColor = System.Drawing.Color.Transparent;
            this.indicator.FillShape = true;
            this.indicator.Location = new System.Drawing.Point(25, 232);
            this.indicator.Name = "indicator";
            this.indicator.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Circle;
            this.indicator.Sides = 5;
            this.indicator.Size = new System.Drawing.Size(17, 17);
            this.indicator.TabIndex = 1;
            this.indicator.Text = "bunifuShapes1";
            // 
            // line
            // 
            this.line.Angle = 90F;
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.line.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.line.BorderThickness = 2;
            this.line.FillColor = System.Drawing.Color.Transparent;
            this.line.FillShape = true;
            this.line.Location = new System.Drawing.Point(28, 237);
            this.line.Name = "line";
            this.line.Shape = Bunifu.UI.WinForms.BunifuShapes.Shapes.Line;
            this.line.Sides = 5;
            this.line.Size = new System.Drawing.Size(10, 171);
            this.line.TabIndex = 1;
            this.line.Text = "bunifuShapes2";
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.AllowAnimations = true;
            this.btnPlaylist.AllowMouseEffects = true;
            this.btnPlaylist.AllowToggling = false;
            this.btnPlaylist.AnimationSpeed = 200;
            this.btnPlaylist.AutoGenerateColors = false;
            this.btnPlaylist.AutoRoundBorders = false;
            this.btnPlaylist.AutoSize = true;
            this.btnPlaylist.AutoSizeLeftIcon = true;
            this.btnPlaylist.AutoSizeRightIcon = true;
            this.btnPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnPlaylist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlaylist.BackgroundImage")));
            this.btnPlaylist.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylist.ButtonText = "Playlist";
            this.btnPlaylist.ButtonTextMarginLeft = 0;
            this.btnPlaylist.ColorContrastOnClick = 45;
            this.btnPlaylist.ColorContrastOnHover = 45;
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPlaylist.CustomizableEdges = borderEdges1;
            this.btnPlaylist.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlaylist.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlaylist.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnPlaylist.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnPlaylist.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPlaylist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPlaylist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.btnPlaylist.IconLeft = null;
            this.btnPlaylist.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlaylist.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPlaylist.IconMarginLeft = 11;
            this.btnPlaylist.IconPadding = 10;
            this.btnPlaylist.IconRight = null;
            this.btnPlaylist.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlaylist.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPlaylist.IconSize = 25;
            this.btnPlaylist.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnPlaylist.IdleBorderRadius = 0;
            this.btnPlaylist.IdleBorderThickness = 0;
            this.btnPlaylist.IdleFillColor = System.Drawing.Color.Empty;
            this.btnPlaylist.IdleIconLeftImage = null;
            this.btnPlaylist.IdleIconRightImage = null;
            this.btnPlaylist.IndicateFocus = false;
            this.btnPlaylist.Location = new System.Drawing.Point(51, 393);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPlaylist.OnDisabledState.BorderRadius = 1;
            this.btnPlaylist.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylist.OnDisabledState.BorderThickness = 1;
            this.btnPlaylist.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPlaylist.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPlaylist.OnDisabledState.IconLeftImage = null;
            this.btnPlaylist.OnDisabledState.IconRightImage = null;
            this.btnPlaylist.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.onHoverState.BorderRadius = 1;
            this.btnPlaylist.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylist.onHoverState.BorderThickness = 1;
            this.btnPlaylist.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnPlaylist.onHoverState.IconLeftImage = null;
            this.btnPlaylist.onHoverState.IconRightImage = null;
            this.btnPlaylist.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.OnIdleState.BorderRadius = 1;
            this.btnPlaylist.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylist.OnIdleState.BorderThickness = 1;
            this.btnPlaylist.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.btnPlaylist.OnIdleState.IconLeftImage = null;
            this.btnPlaylist.OnIdleState.IconRightImage = null;
            this.btnPlaylist.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.OnPressedState.BorderRadius = 1;
            this.btnPlaylist.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPlaylist.OnPressedState.BorderThickness = 1;
            this.btnPlaylist.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.OnPressedState.IconLeftImage = null;
            this.btnPlaylist.OnPressedState.IconRightImage = null;
            this.btnPlaylist.Size = new System.Drawing.Size(55, 20);
            this.btnPlaylist.TabIndex = 4;
            this.btnPlaylist.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPlaylist.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPlaylist.TextMarginLeft = 0;
            this.btnPlaylist.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPlaylist.UseDefaultRadiusAndThickness = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnAlbum_Click);
            // 
            // btnAlbum
            // 
            this.btnAlbum.AllowAnimations = true;
            this.btnAlbum.AllowMouseEffects = true;
            this.btnAlbum.AllowToggling = false;
            this.btnAlbum.AnimationSpeed = 200;
            this.btnAlbum.AutoGenerateColors = false;
            this.btnAlbum.AutoRoundBorders = false;
            this.btnAlbum.AutoSize = true;
            this.btnAlbum.AutoSizeLeftIcon = true;
            this.btnAlbum.AutoSizeRightIcon = true;
            this.btnAlbum.BackColor = System.Drawing.Color.Transparent;
            this.btnAlbum.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnAlbum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlbum.BackgroundImage")));
            this.btnAlbum.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlbum.ButtonText = "Album";
            this.btnAlbum.ButtonTextMarginLeft = 0;
            this.btnAlbum.ColorContrastOnClick = 45;
            this.btnAlbum.ColorContrastOnHover = 45;
            this.btnAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAlbum.CustomizableEdges = borderEdges2;
            this.btnAlbum.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAlbum.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAlbum.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnAlbum.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnAlbum.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAlbum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.btnAlbum.IconLeft = null;
            this.btnAlbum.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlbum.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlbum.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAlbum.IconMarginLeft = 11;
            this.btnAlbum.IconPadding = 10;
            this.btnAlbum.IconRight = null;
            this.btnAlbum.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlbum.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlbum.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAlbum.IconSize = 25;
            this.btnAlbum.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnAlbum.IdleBorderRadius = 0;
            this.btnAlbum.IdleBorderThickness = 0;
            this.btnAlbum.IdleFillColor = System.Drawing.Color.Empty;
            this.btnAlbum.IdleIconLeftImage = null;
            this.btnAlbum.IdleIconRightImage = null;
            this.btnAlbum.IndicateFocus = false;
            this.btnAlbum.Location = new System.Drawing.Point(51, 312);
            this.btnAlbum.Name = "btnAlbum";
            this.btnAlbum.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAlbum.OnDisabledState.BorderRadius = 1;
            this.btnAlbum.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlbum.OnDisabledState.BorderThickness = 1;
            this.btnAlbum.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAlbum.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAlbum.OnDisabledState.IconLeftImage = null;
            this.btnAlbum.OnDisabledState.IconRightImage = null;
            this.btnAlbum.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAlbum.onHoverState.BorderRadius = 1;
            this.btnAlbum.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlbum.onHoverState.BorderThickness = 1;
            this.btnAlbum.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAlbum.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAlbum.onHoverState.IconLeftImage = null;
            this.btnAlbum.onHoverState.IconRightImage = null;
            this.btnAlbum.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAlbum.OnIdleState.BorderRadius = 1;
            this.btnAlbum.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlbum.OnIdleState.BorderThickness = 1;
            this.btnAlbum.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnAlbum.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.btnAlbum.OnIdleState.IconLeftImage = null;
            this.btnAlbum.OnIdleState.IconRightImage = null;
            this.btnAlbum.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAlbum.OnPressedState.BorderRadius = 1;
            this.btnAlbum.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAlbum.OnPressedState.BorderThickness = 1;
            this.btnAlbum.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btnAlbum.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.btnAlbum.OnPressedState.IconLeftImage = null;
            this.btnAlbum.OnPressedState.IconRightImage = null;
            this.btnAlbum.Size = new System.Drawing.Size(53, 20);
            this.btnAlbum.TabIndex = 3;
            this.btnAlbum.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAlbum.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAlbum.TextMarginLeft = 0;
            this.btnAlbum.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAlbum.UseDefaultRadiusAndThickness = true;
            this.btnAlbum.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnNowPlaying
            // 
            this.btnNowPlaying.AllowAnimations = true;
            this.btnNowPlaying.AllowMouseEffects = true;
            this.btnNowPlaying.AllowToggling = false;
            this.btnNowPlaying.AnimationSpeed = 200;
            this.btnNowPlaying.AutoGenerateColors = false;
            this.btnNowPlaying.AutoRoundBorders = false;
            this.btnNowPlaying.AutoSize = true;
            this.btnNowPlaying.AutoSizeLeftIcon = true;
            this.btnNowPlaying.AutoSizeRightIcon = true;
            this.btnNowPlaying.BackColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btnNowPlaying.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNowPlaying.BackgroundImage")));
            this.btnNowPlaying.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNowPlaying.ButtonText = "Now Playing";
            this.btnNowPlaying.ButtonTextMarginLeft = 0;
            this.btnNowPlaying.ColorContrastOnClick = 45;
            this.btnNowPlaying.ColorContrastOnHover = 45;
            this.btnNowPlaying.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnNowPlaying.CustomizableEdges = borderEdges3;
            this.btnNowPlaying.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNowPlaying.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNowPlaying.DisabledFillColor = System.Drawing.Color.Empty;
            this.btnNowPlaying.DisabledForecolor = System.Drawing.Color.Empty;
            this.btnNowPlaying.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNowPlaying.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNowPlaying.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.btnNowPlaying.IconLeft = null;
            this.btnNowPlaying.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNowPlaying.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNowPlaying.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNowPlaying.IconMarginLeft = 11;
            this.btnNowPlaying.IconPadding = 10;
            this.btnNowPlaying.IconRight = null;
            this.btnNowPlaying.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNowPlaying.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnNowPlaying.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNowPlaying.IconSize = 25;
            this.btnNowPlaying.IdleBorderColor = System.Drawing.Color.Empty;
            this.btnNowPlaying.IdleBorderRadius = 0;
            this.btnNowPlaying.IdleBorderThickness = 0;
            this.btnNowPlaying.IdleFillColor = System.Drawing.Color.Empty;
            this.btnNowPlaying.IdleIconLeftImage = null;
            this.btnNowPlaying.IdleIconRightImage = null;
            this.btnNowPlaying.IndicateFocus = false;
            this.btnNowPlaying.Location = new System.Drawing.Point(51, 232);
            this.btnNowPlaying.Name = "btnNowPlaying";
            this.btnNowPlaying.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNowPlaying.OnDisabledState.BorderRadius = 1;
            this.btnNowPlaying.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNowPlaying.OnDisabledState.BorderThickness = 1;
            this.btnNowPlaying.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNowPlaying.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNowPlaying.OnDisabledState.IconLeftImage = null;
            this.btnNowPlaying.OnDisabledState.IconRightImage = null;
            this.btnNowPlaying.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.onHoverState.BorderRadius = 1;
            this.btnNowPlaying.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNowPlaying.onHoverState.BorderThickness = 1;
            this.btnNowPlaying.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnNowPlaying.onHoverState.IconLeftImage = null;
            this.btnNowPlaying.onHoverState.IconRightImage = null;
            this.btnNowPlaying.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnIdleState.BorderRadius = 1;
            this.btnNowPlaying.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNowPlaying.OnIdleState.BorderThickness = 1;
            this.btnNowPlaying.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.btnNowPlaying.OnIdleState.IconLeftImage = null;
            this.btnNowPlaying.OnIdleState.IconRightImage = null;
            this.btnNowPlaying.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnPressedState.BorderRadius = 1;
            this.btnNowPlaying.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNowPlaying.OnPressedState.BorderThickness = 1;
            this.btnNowPlaying.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnPressedState.ForeColor = System.Drawing.Color.Transparent;
            this.btnNowPlaying.OnPressedState.IconLeftImage = null;
            this.btnNowPlaying.OnPressedState.IconRightImage = null;
            this.btnNowPlaying.Size = new System.Drawing.Size(92, 20);
            this.btnNowPlaying.TabIndex = 2;
            this.btnNowPlaying.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNowPlaying.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNowPlaying.TextMarginLeft = 0;
            this.btnNowPlaying.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNowPlaying.UseDefaultRadiusAndThickness = true;
            this.btnNowPlaying.Click += new System.EventHandler(this.btnNowPlaying_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(53, 107);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(101, 33);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Player";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(58)))), ((int)(((byte)(105)))));
            this.toppanel.Controls.Add(this.btnClose);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(228, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(724, 56);
            this.toppanel.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = false;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 20;
            this.btnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(678, -5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 0;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 20;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // songTitleLabel
            // 
            this.songTitleLabel.AllowParentOverrides = false;
            this.songTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.songTitleLabel.AutoEllipsis = false;
            this.songTitleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.songTitleLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.songTitleLabel.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold);
            this.songTitleLabel.ForeColor = System.Drawing.Color.Black;
            this.songTitleLabel.Location = new System.Drawing.Point(225, 129);
            this.songTitleLabel.Name = "songTitleLabel";
            this.songTitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.songTitleLabel.Size = new System.Drawing.Size(144, 37);
            this.songTitleLabel.TabIndex = 6;
            this.songTitleLabel.Text = "Song Title";
            this.songTitleLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.songTitleLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bottompanel
            // 
            this.bottompanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(58)))), ((int)(((byte)(105)))));
            this.bottompanel.Controls.Add(this.pictureBox1);
            this.bottompanel.Controls.Add(this.soundSlider);
            this.bottompanel.Controls.Add(this.btnPrev);
            this.bottompanel.Controls.Add(this.btnPlay);
            this.bottompanel.Controls.Add(this.btnPause);
            this.bottompanel.Controls.Add(this.btnNext);
            this.bottompanel.Controls.Add(this.songSlider);
            this.bottompanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottompanel.Location = new System.Drawing.Point(228, 580);
            this.bottompanel.Name = "bottompanel";
            this.bottompanel.Size = new System.Drawing.Size(724, 56);
            this.bottompanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(590, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // soundSlider
            // 
            this.soundSlider.AllowCursorChanges = true;
            this.soundSlider.AllowHomeEndKeysDetection = false;
            this.soundSlider.AllowIncrementalClickMoves = true;
            this.soundSlider.AllowMouseDownEffects = false;
            this.soundSlider.AllowMouseHoverEffects = false;
            this.soundSlider.AllowScrollingAnimations = true;
            this.soundSlider.AllowScrollKeysDetection = true;
            this.soundSlider.AllowScrollOptionsMenu = true;
            this.soundSlider.AllowShrinkingOnFocusLost = false;
            this.soundSlider.BackColor = System.Drawing.Color.Transparent;
            this.soundSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("soundSlider.BackgroundImage")));
            this.soundSlider.BindingContainer = null;
            this.soundSlider.BorderRadius = 2;
            this.soundSlider.BorderThickness = 1;
            this.soundSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.soundSlider.DrawThickBorder = false;
            this.soundSlider.DurationBeforeShrink = 2000;
            this.soundSlider.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.soundSlider.LargeChange = 10;
            this.soundSlider.Location = new System.Drawing.Point(638, 14);
            this.soundSlider.Maximum = 100;
            this.soundSlider.Minimum = 0;
            this.soundSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.soundSlider.MinimumThumbLength = 18;
            this.soundSlider.Name = "soundSlider";
            this.soundSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.soundSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.soundSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.soundSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(205)))));
            this.soundSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(205)))));
            this.soundSlider.ShrinkSizeLimit = 3;
            this.soundSlider.Size = new System.Drawing.Size(74, 31);
            this.soundSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(205)))));
            this.soundSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.soundSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.soundSlider.SmallChange = 1;
            this.soundSlider.TabIndex = 11;
            this.soundSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(205)))));
            this.soundSlider.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.soundSlider.ThumbLength = 18;
            this.soundSlider.ThumbMargin = 1;
            this.soundSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.soundSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.soundSlider.Value = 50;
            this.soundSlider.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.soundSlider_Scroll);
            // 
            // btnPrev
            // 
            this.btnPrev.ActiveImage = null;
            this.btnPrev.AllowAnimations = true;
            this.btnPrev.AllowBuffering = false;
            this.btnPrev.AllowToggling = false;
            this.btnPrev.AllowZooming = false;
            this.btnPrev.AllowZoomingOnFocus = false;
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrev.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.ErrorImage")));
            this.btnPrev.FadeWhenInactive = false;
            this.btnPrev.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageActive = null;
            this.btnPrev.ImageLocation = null;
            this.btnPrev.ImageMargin = 20;
            this.btnPrev.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrev.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnPrev.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.InitialImage")));
            this.btnPrev.Location = new System.Drawing.Point(19, 7);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Rotation = 180;
            this.btnPrev.ShowActiveImage = true;
            this.btnPrev.ShowCursorChanges = true;
            this.btnPrev.ShowImageBorders = true;
            this.btnPrev.ShowSizeMarkers = false;
            this.btnPrev.Size = new System.Drawing.Size(40, 40);
            this.btnPrev.TabIndex = 10;
            this.btnPrev.ToolTipText = "";
            this.btnPrev.WaitOnLoad = false;
            this.btnPrev.Zoom = 20;
            this.btnPrev.ZoomSpeed = 10;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.ActiveImage = null;
            this.btnPlay.AllowAnimations = true;
            this.btnPlay.AllowBuffering = false;
            this.btnPlay.AllowToggling = false;
            this.btnPlay.AllowZooming = false;
            this.btnPlay.AllowZoomingOnFocus = false;
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlay.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.ErrorImage")));
            this.btnPlay.FadeWhenInactive = false;
            this.btnPlay.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.ImageActive = null;
            this.btnPlay.ImageLocation = null;
            this.btnPlay.ImageMargin = 20;
            this.btnPlay.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPlay.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnPlay.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.InitialImage")));
            this.btnPlay.Location = new System.Drawing.Point(55, 8);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Rotation = 0;
            this.btnPlay.ShowActiveImage = true;
            this.btnPlay.ShowCursorChanges = true;
            this.btnPlay.ShowImageBorders = true;
            this.btnPlay.ShowSizeMarkers = false;
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 9;
            this.btnPlay.ToolTipText = "";
            this.btnPlay.WaitOnLoad = false;
            this.btnPlay.Zoom = 20;
            this.btnPlay.ZoomSpeed = 10;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.ActiveImage = null;
            this.btnPause.AllowAnimations = true;
            this.btnPause.AllowBuffering = false;
            this.btnPause.AllowToggling = false;
            this.btnPause.AllowZooming = false;
            this.btnPause.AllowZoomingOnFocus = false;
            this.btnPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPause.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnPause.ErrorImage")));
            this.btnPause.FadeWhenInactive = false;
            this.btnPause.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageActive = null;
            this.btnPause.ImageLocation = null;
            this.btnPause.ImageMargin = 20;
            this.btnPause.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPause.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnPause.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnPause.InitialImage")));
            this.btnPause.Location = new System.Drawing.Point(91, 8);
            this.btnPause.Name = "btnPause";
            this.btnPause.Rotation = 0;
            this.btnPause.ShowActiveImage = true;
            this.btnPause.ShowCursorChanges = true;
            this.btnPause.ShowImageBorders = true;
            this.btnPause.ShowSizeMarkers = false;
            this.btnPause.Size = new System.Drawing.Size(40, 40);
            this.btnPause.TabIndex = 8;
            this.btnPause.ToolTipText = "";
            this.btnPause.WaitOnLoad = false;
            this.btnPause.Zoom = 20;
            this.btnPause.ZoomSpeed = 10;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnNext
            // 
            this.btnNext.ActiveImage = null;
            this.btnNext.AllowAnimations = true;
            this.btnNext.AllowBuffering = false;
            this.btnNext.AllowToggling = false;
            this.btnNext.AllowZooming = false;
            this.btnNext.AllowZoomingOnFocus = false;
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnNext.ErrorImage")));
            this.btnNext.FadeWhenInactive = false;
            this.btnNext.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageActive = null;
            this.btnNext.ImageLocation = null;
            this.btnNext.ImageMargin = 20;
            this.btnNext.ImageSize = new System.Drawing.Size(20, 20);
            this.btnNext.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btnNext.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnNext.InitialImage")));
            this.btnNext.Location = new System.Drawing.Point(127, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Rotation = 0;
            this.btnNext.ShowActiveImage = true;
            this.btnNext.ShowCursorChanges = true;
            this.btnNext.ShowImageBorders = true;
            this.btnNext.ShowSizeMarkers = false;
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 7;
            this.btnNext.ToolTipText = "";
            this.btnNext.WaitOnLoad = false;
            this.btnNext.Zoom = 20;
            this.btnNext.ZoomSpeed = 10;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // songSlider
            // 
            this.songSlider.AllowCursorChanges = true;
            this.songSlider.AllowHomeEndKeysDetection = false;
            this.songSlider.AllowIncrementalClickMoves = true;
            this.songSlider.AllowMouseDownEffects = false;
            this.songSlider.AllowMouseHoverEffects = false;
            this.songSlider.AllowScrollingAnimations = true;
            this.songSlider.AllowScrollKeysDetection = true;
            this.songSlider.AllowScrollOptionsMenu = true;
            this.songSlider.AllowShrinkingOnFocusLost = false;
            this.songSlider.BackColor = System.Drawing.Color.Transparent;
            this.songSlider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("songSlider.BackgroundImage")));
            this.songSlider.BindingContainer = null;
            this.songSlider.BorderRadius = 2;
            this.songSlider.BorderThickness = 1;
            this.songSlider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.songSlider.DrawThickBorder = false;
            this.songSlider.DurationBeforeShrink = 2000;
            this.songSlider.ElapsedColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.songSlider.LargeChange = 10;
            this.songSlider.Location = new System.Drawing.Point(183, 14);
            this.songSlider.Maximum = 100;
            this.songSlider.Minimum = 0;
            this.songSlider.MinimumSize = new System.Drawing.Size(0, 31);
            this.songSlider.MinimumThumbLength = 18;
            this.songSlider.Name = "songSlider";
            this.songSlider.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.songSlider.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.songSlider.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.songSlider.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(205)))));
            this.songSlider.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(205)))));
            this.songSlider.ShrinkSizeLimit = 3;
            this.songSlider.Size = new System.Drawing.Size(356, 31);
            this.songSlider.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(205)))));
            this.songSlider.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.songSlider.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.songSlider.SmallChange = 1;
            this.songSlider.TabIndex = 0;
            this.songSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(205)))));
            this.songSlider.ThumbFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(107)))));
            this.songSlider.ThumbLength = 35;
            this.songSlider.ThumbMargin = 1;
            this.songSlider.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.songSlider.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.songSlider.Value = 50;
            this.songSlider.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.songSlider_Scroll);
            // 
            // bunifuPages1
            // 
            this.bunifuPages1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.bunifuPages1.AllowTransitions = false;
            this.bunifuPages1.Controls.Add(this.nowPlayingTab);
            this.bunifuPages1.Controls.Add(this.albumTab);
            this.bunifuPages1.Controls.Add(this.playlistTab);
            this.bunifuPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPages1.Location = new System.Drawing.Point(228, 56);
            this.bunifuPages1.Multiline = true;
            this.bunifuPages1.Name = "bunifuPages1";
            this.bunifuPages1.Page = this.playlistTab;
            this.bunifuPages1.PageIndex = 2;
            this.bunifuPages1.PageName = "playlistTab";
            this.bunifuPages1.PageTitle = "Playlist";
            this.bunifuPages1.SelectedIndex = 0;
            this.bunifuPages1.Size = new System.Drawing.Size(724, 524);
            this.bunifuPages1.TabIndex = 3;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuPages1.Transition = animation1;
            this.bunifuPages1.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // nowPlayingTab
            // 
            this.nowPlayingTab.Controls.Add(this.songTitleLabel);
            this.nowPlayingTab.Controls.Add(this.btnAddSong);
            this.nowPlayingTab.Controls.Add(this.bunifuShadowPanel1);
            this.nowPlayingTab.Location = new System.Drawing.Point(4, 4);
            this.nowPlayingTab.Name = "nowPlayingTab";
            this.nowPlayingTab.Padding = new System.Windows.Forms.Padding(3);
            this.nowPlayingTab.Size = new System.Drawing.Size(716, 495);
            this.nowPlayingTab.TabIndex = 0;
            this.nowPlayingTab.Text = "NowPlaying";
            this.nowPlayingTab.UseVisualStyleBackColor = true;
            // 
            // btnAddSong
            // 
            this.btnAddSong.ActiveImage = null;
            this.btnAddSong.AllowAnimations = true;
            this.btnAddSong.AllowBuffering = false;
            this.btnAddSong.AllowToggling = false;
            this.btnAddSong.AllowZooming = false;
            this.btnAddSong.AllowZoomingOnFocus = false;
            this.btnAddSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddSong.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSong.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddSong.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnAddSong.ErrorImage")));
            this.btnAddSong.FadeWhenInactive = false;
            this.btnAddSong.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnAddSong.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSong.Image")));
            this.btnAddSong.ImageActive = null;
            this.btnAddSong.ImageLocation = null;
            this.btnAddSong.ImageMargin = 20;
            this.btnAddSong.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddSong.ImageZoomSize = new System.Drawing.Size(50, 50);
            this.btnAddSong.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnAddSong.InitialImage")));
            this.btnAddSong.Location = new System.Drawing.Point(255, 191);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Rotation = 0;
            this.btnAddSong.ShowActiveImage = true;
            this.btnAddSong.ShowCursorChanges = true;
            this.btnAddSong.ShowImageBorders = true;
            this.btnAddSong.ShowSizeMarkers = false;
            this.btnAddSong.Size = new System.Drawing.Size(50, 50);
            this.btnAddSong.TabIndex = 13;
            this.btnAddSong.ToolTipText = "";
            this.btnAddSong.WaitOnLoad = false;
            this.btnAddSong.Zoom = 20;
            this.btnAddSong.ZoomSpeed = 10;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.White;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 1;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.pictureBox2);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(15, 129);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(173, 158);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // albumTab
            // 
            this.albumTab.Location = new System.Drawing.Point(4, 4);
            this.albumTab.Name = "albumTab";
            this.albumTab.Padding = new System.Windows.Forms.Padding(3);
            this.albumTab.Size = new System.Drawing.Size(716, 495);
            this.albumTab.TabIndex = 1;
            this.albumTab.Text = "Album";
            this.albumTab.UseVisualStyleBackColor = true;
            // 
            // playlistTab
            // 
            this.playlistTab.Controls.Add(this.playlistTable);
            this.playlistTab.Location = new System.Drawing.Point(4, 4);
            this.playlistTab.Name = "playlistTab";
            this.playlistTab.Padding = new System.Windows.Forms.Padding(3);
            this.playlistTab.Size = new System.Drawing.Size(716, 495);
            this.playlistTab.TabIndex = 2;
            this.playlistTab.Text = "Playlist";
            this.playlistTab.UseVisualStyleBackColor = true;
            // 
            // playlistTable
            // 
            this.playlistTable.AutoSize = true;
            this.playlistTable.ColumnCount = 1;
            this.playlistTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playlistTable.Location = new System.Drawing.Point(8, 18);
            this.playlistTable.Name = "playlistTable";
            this.playlistTable.RowCount = 5;
            this.playlistTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playlistTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playlistTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.playlistTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.playlistTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.playlistTable.Size = new System.Drawing.Size(702, 106);
            this.playlistTable.TabIndex = 1;
            this.playlistTable.Paint += new System.Windows.Forms.PaintEventHandler(this.playlistTable_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 636);
            this.Controls.Add(this.bunifuPages1);
            this.Controls.Add(this.bottompanel);
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.sidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.toppanel.ResumeLayout(false);
            this.bottompanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuPages1.ResumeLayout(false);
            this.nowPlayingTab.ResumeLayout(false);
            this.nowPlayingTab.PerformLayout();
            this.bunifuShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.playlistTab.ResumeLayout(false);
            this.playlistTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNowPlaying;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPlaylist;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAlbum;
        private Bunifu.UI.WinForms.BunifuShapes indicator;
        private Bunifu.UI.WinForms.BunifuShapes line;
        private System.Windows.Forms.Panel toppanel;
        private Bunifu.UI.WinForms.BunifuPages bunifuPages1;
        private System.Windows.Forms.TabPage nowPlayingTab;
        private System.Windows.Forms.TabPage albumTab;
        private System.Windows.Forms.Panel bottompanel;
        private Bunifu.UI.WinForms.BunifuHSlider songSlider;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private Bunifu.UI.WinForms.BunifuLabel songTitleLabel;
        private Bunifu.UI.WinForms.BunifuImageButton btnNext;
        private Bunifu.UI.WinForms.BunifuImageButton btnPlay;
        private Bunifu.UI.WinForms.BunifuImageButton btnPause;
        private Bunifu.UI.WinForms.BunifuImageButton btnPrev;
        private Bunifu.UI.WinForms.BunifuHSlider soundSlider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuImageButton btnAddSong;
        private System.Windows.Forms.TabPage playlistTab;
        private System.Windows.Forms.TableLayoutPanel playlistTable;
    }
}

