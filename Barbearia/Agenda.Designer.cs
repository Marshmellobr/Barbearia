namespace Barbearia
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            Bt_Sair_agenda = new Button();
            panel1 = new Panel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Bt_Sair_agenda
            // 
            Bt_Sair_agenda.Location = new Point(682, 510);
            Bt_Sair_agenda.Name = "Bt_Sair_agenda";
            Bt_Sair_agenda.Size = new Size(86, 35);
            Bt_Sair_agenda.TabIndex = 0;
            Bt_Sair_agenda.Text = "Sair";
            Bt_Sair_agenda.UseVisualStyleBackColor = true;
            Bt_Sair_agenda.Click += Bt_Sair_agenda_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Location = new Point(638, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(130, 166);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(3, 46);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(89, 18);
            linkLabel3.TabIndex = 5;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "* Serviços";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(3, 77);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(75, 18);
            linkLabel2.TabIndex = 4;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "* Cliente";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(3, 16);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 18);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "* Funcionario";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(721, 12);
            button1.Name = "button1";
            button1.Size = new Size(47, 23);
            button1.TabIndex = 3;
            button1.Text = ". . .";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 557);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(Bt_Sair_agenda);
            Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Agenda";
            Text = "Agenda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Bt_Sair_agenda;
        private Panel panel1;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private Button button1;
    }
}