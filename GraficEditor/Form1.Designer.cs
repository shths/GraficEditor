namespace GraficEditor
{
    partial class mdiGeneral
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuGeneral = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.mnuNewPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenPicture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSavePicture = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иконкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.строкаСостоянияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размерИзображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuGeneral
            // 
            this.mnuGeneral.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuTools,
            this.mnuColor,
            this.mnuWindow,
            this.видToolStripMenuItem});
            this.mnuGeneral.Location = new System.Drawing.Point(0, 0);
            this.mnuGeneral.Name = "mnuGeneral";
            this.mnuGeneral.Size = new System.Drawing.Size(800, 28);
            this.mnuGeneral.TabIndex = 1;
            this.mnuGeneral.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewPicture,
            this.mnuOpenPicture,
            this.mnuSavePicture});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(59, 24);
            this.mnuFile.Text = "Файл";
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.ToolStripMenuItem2,
            this.ToolStripMenuItem3});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(117, 24);
            this.mnuTools.Text = "Инструменты";
            // 
            // mnuColor
            // 
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(56, 24);
            this.mnuColor.Text = "Цвет";
            this.mnuColor.Click += new System.EventHandler(this.mnuColor_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадToolStripMenuItem,
            this.вертикальноToolStripMenuItem,
            this.горизонтальноToolStripMenuItem,
            this.иконкиToolStripMenuItem});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(59, 24);
            this.mnuWindow.Text = "Окно";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem1.Text = "Линии в центр";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem2.Text = "Квадратики";
            this.ToolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.ToolStripMenuItem3.Text = "Перекрестье";
            this.ToolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // mnuNewPicture
            // 
            this.mnuNewPicture.Name = "mnuNewPicture";
            this.mnuNewPicture.Size = new System.Drawing.Size(266, 26);
            this.mnuNewPicture.Text = "Новое полотно";
            this.mnuNewPicture.Click += new System.EventHandler(this.mnuNewPicture_Click);
            // 
            // mnuOpenPicture
            // 
            this.mnuOpenPicture.Name = "mnuOpenPicture";
            this.mnuOpenPicture.Size = new System.Drawing.Size(266, 26);
            this.mnuOpenPicture.Text = "Открыть изображение";
            this.mnuOpenPicture.Click += new System.EventHandler(this.mnuOpenPicture_Click);
            // 
            // mnuSavePicture
            // 
            this.mnuSavePicture.Name = "mnuSavePicture";
            this.mnuSavePicture.Size = new System.Drawing.Size(266, 26);
            this.mnuSavePicture.Text = "Сохранить изображение";
            this.mnuSavePicture.Click += new System.EventHandler(this.mnuSavePicture_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.строкаСостоянияToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // каскадToolStripMenuItem
            // 
            this.каскадToolStripMenuItem.Name = "каскадToolStripMenuItem";
            this.каскадToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.каскадToolStripMenuItem.Text = "Каскад";
            this.каскадToolStripMenuItem.Click += new System.EventHandler(this.CascadeWindows);
            // 
            // вертикальноToolStripMenuItem
            // 
            this.вертикальноToolStripMenuItem.Name = "вертикальноToolStripMenuItem";
            this.вертикальноToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вертикальноToolStripMenuItem.Text = "Вертикально";
            this.вертикальноToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalWindows);
            // 
            // горизонтальноToolStripMenuItem
            // 
            this.горизонтальноToolStripMenuItem.Name = "горизонтальноToolStripMenuItem";
            this.горизонтальноToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.горизонтальноToolStripMenuItem.Text = "Горизонтально";
            this.горизонтальноToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalWindows);
            // 
            // иконкиToolStripMenuItem
            // 
            this.иконкиToolStripMenuItem.Name = "иконкиToolStripMenuItem";
            this.иконкиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.иконкиToolStripMenuItem.Text = "Иконки";
            this.иконкиToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIcons);
            // 
            // строкаСостоянияToolStripMenuItem
            // 
            this.строкаСостоянияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размерИзображенияToolStripMenuItem});
            this.строкаСостоянияToolStripMenuItem.Name = "строкаСостоянияToolStripMenuItem";
            this.строкаСостоянияToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.строкаСостоянияToolStripMenuItem.Text = "Строка состояния";
            // 
            // размерИзображенияToolStripMenuItem
            // 
            this.размерИзображенияToolStripMenuItem.Name = "размерИзображенияToolStripMenuItem";
            this.размерИзображенияToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.размерИзображенияToolStripMenuItem.Text = "Размер изображения";
            // 
            // mdiGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuGeneral);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuGeneral;
            this.Name = "mdiGeneral";
            this.Text = "Графический редактор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuGeneral.ResumeLayout(false);
            this.mnuGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuGeneral;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnuNewPicture;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenPicture;
        private System.Windows.Forms.ToolStripMenuItem mnuSavePicture;
        private System.Windows.Forms.ToolStripMenuItem каскадToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иконкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem строкаСостоянияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размерИзображенияToolStripMenuItem;
    }
}

