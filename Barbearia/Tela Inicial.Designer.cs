namespace Barbearia
{
    partial class Tela_Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela_Inicial));
            Bt_Agenda = new Button();
            Panel_1 = new Panel();
            Bt_Finança = new Button();
            Bt_Estoque = new Button();
            Bt_Cliente = new Button();
            Bt_Voltar = new Button();
            Panel_1.SuspendLayout();
            SuspendLayout();
            // 
            // Bt_Agenda
            // 
            Bt_Agenda.Image = (Image)resources.GetObject("Bt_Agenda.Image");
            Bt_Agenda.Location = new Point(14, 14);
            Bt_Agenda.Margin = new Padding(4);
            Bt_Agenda.Name = "Bt_Agenda";
            Bt_Agenda.Size = new Size(167, 201);
            Bt_Agenda.TabIndex = 0;
            Bt_Agenda.Text = "&Agenda";
            Bt_Agenda.TextAlign = ContentAlignment.BottomCenter;
            Bt_Agenda.UseVisualStyleBackColor = true;
            Bt_Agenda.Click += Bt_Agenda_Click;
            // 
            // Panel_1
            // 
            Panel_1.Controls.Add(Bt_Finança);
            Panel_1.Controls.Add(Bt_Estoque);
            Panel_1.Controls.Add(Bt_Cliente);
            Panel_1.Controls.Add(Bt_Agenda);
            Panel_1.Location = new Point(12, 12);
            Panel_1.Name = "Panel_1";
            Panel_1.Size = new Size(717, 240);
            Panel_1.TabIndex = 1;
            // 
            // Bt_Finança
            // 
            Bt_Finança.Image = (Image)resources.GetObject("Bt_Finança.Image");
            Bt_Finança.Location = new Point(539, 14);
            Bt_Finança.Margin = new Padding(4);
            Bt_Finança.Name = "Bt_Finança";
            Bt_Finança.Size = new Size(167, 201);
            Bt_Finança.TabIndex = 3;
            Bt_Finança.Text = "&Finança";
            Bt_Finança.TextAlign = ContentAlignment.BottomCenter;
            Bt_Finança.UseVisualStyleBackColor = true;
            Bt_Finança.Click += Bt_Finança_Click;
            // 
            // Bt_Estoque
            // 
            Bt_Estoque.Image = (Image)resources.GetObject("Bt_Estoque.Image");
            Bt_Estoque.Location = new Point(364, 14);
            Bt_Estoque.Margin = new Padding(4);
            Bt_Estoque.Name = "Bt_Estoque";
            Bt_Estoque.Size = new Size(167, 201);
            Bt_Estoque.TabIndex = 2;
            Bt_Estoque.Text = "&Estoque";
            Bt_Estoque.TextAlign = ContentAlignment.BottomCenter;
            Bt_Estoque.UseVisualStyleBackColor = true;
            Bt_Estoque.Click += Bt_Estoque_Click;
            // 
            // Bt_Cliente
            // 
            Bt_Cliente.Image = (Image)resources.GetObject("Bt_Cliente.Image");
            Bt_Cliente.Location = new Point(189, 14);
            Bt_Cliente.Margin = new Padding(4);
            Bt_Cliente.Name = "Bt_Cliente";
            Bt_Cliente.Size = new Size(167, 201);
            Bt_Cliente.TabIndex = 1;
            Bt_Cliente.Text = "&Cliente";
            Bt_Cliente.TextAlign = ContentAlignment.BottomCenter;
            Bt_Cliente.UseVisualStyleBackColor = true;
            Bt_Cliente.Click += Bt_Cliente_Click;
            // 
            // Bt_Voltar
            // 
            Bt_Voltar.Location = new Point(633, 264);
            Bt_Voltar.Name = "Bt_Voltar";
            Bt_Voltar.Size = new Size(85, 31);
            Bt_Voltar.TabIndex = 2;
            Bt_Voltar.Text = "&Voltar";
            Bt_Voltar.UseVisualStyleBackColor = true;
            Bt_Voltar.Click += Bt_Voltar_Click;
            // 
            // Tela_Inicial
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 307);
            Controls.Add(Bt_Voltar);
            Controls.Add(Panel_1);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Tela_Inicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu inicial";
            Load += Tela_Inicial_Load;
            Panel_1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button Bt_Agenda;
        private Panel Panel_1;
        private Button Bt_Finança;
        private Button Bt_Estoque;
        private Button Bt_Cliente;
        private Button Bt_Voltar;
    }
}