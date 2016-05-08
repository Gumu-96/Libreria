namespace Libreria
{
    partial class frmMenuColor
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
            this.btnColor4 = new MetroFramework.Controls.MetroButton();
            this.btnColor3 = new MetroFramework.Controls.MetroButton();
            this.btnColor2 = new MetroFramework.Controls.MetroButton();
            this.btnColor1 = new MetroFramework.Controls.MetroButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.btnRegresar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnColor4
            // 
            this.btnColor4.BackgroundImage = global::Libreria.Properties.Resources.colorD;
            this.btnColor4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColor4.Location = new System.Drawing.Point(320, 240);
            this.btnColor4.Name = "btnColor4";
            this.btnColor4.Size = new System.Drawing.Size(150, 70);
            this.btnColor4.TabIndex = 3;
            this.btnColor4.UseSelectable = true;
            this.btnColor4.Click += new System.EventHandler(this.btnColor4_Click);
            // 
            // btnColor3
            // 
            this.btnColor3.BackgroundImage = global::Libreria.Properties.Resources.color3;
            this.btnColor3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColor3.Location = new System.Drawing.Point(120, 240);
            this.btnColor3.Name = "btnColor3";
            this.btnColor3.Size = new System.Drawing.Size(150, 70);
            this.btnColor3.TabIndex = 2;
            this.btnColor3.UseSelectable = true;
            this.btnColor3.Click += new System.EventHandler(this.btnColor3_Click);
            // 
            // btnColor2
            // 
            this.btnColor2.BackgroundImage = global::Libreria.Properties.Resources.color2;
            this.btnColor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColor2.Location = new System.Drawing.Point(320, 130);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(150, 70);
            this.btnColor2.TabIndex = 1;
            this.btnColor2.UseSelectable = true;
            this.btnColor2.Click += new System.EventHandler(this.btnColor2_Click);
            // 
            // btnColor1
            // 
            this.btnColor1.BackgroundImage = global::Libreria.Properties.Resources.color1;
            this.btnColor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColor1.Location = new System.Drawing.Point(120, 130);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(150, 70);
            this.btnColor1.TabIndex = 0;
            this.btnColor1.UseSelectable = true;
            this.btnColor1.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 375);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(600, 25);
            this.materialDivider1.TabIndex = 17;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackgroundImage = global::Libreria.Properties.Resources.regresarTrans;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegresar.Location = new System.Drawing.Point(0, 375);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 25);
            this.btnRegresar.TabIndex = 21;
            this.btnRegresar.UseSelectable = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmMenuColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.btnColor4);
            this.Controls.Add(this.btnColor3);
            this.Controls.Add(this.btnColor2);
            this.Controls.Add(this.btnColor1);
            this.MaximizeBox = false;
            this.Name = "frmMenuColor";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color de la aplicación";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenuColor_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnColor1;
        private MetroFramework.Controls.MetroButton btnColor2;
        private MetroFramework.Controls.MetroButton btnColor3;
        private MetroFramework.Controls.MetroButton btnColor4;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MetroFramework.Controls.MetroButton btnRegresar;
    }
}