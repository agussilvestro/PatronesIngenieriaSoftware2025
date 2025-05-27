namespace Mediator.Chat
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstRoom = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnEnviarA2 = new System.Windows.Forms.Button();
            this.btnEnviarA1 = new System.Windows.Forms.Button();
            this.lstMensajesU2 = new System.Windows.Forms.ListBox();
            this.lstMensajesU1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstRoom
            // 
            this.lstRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRoom.FormattingEnabled = true;
            this.lstRoom.ItemHeight = 16;
            this.lstRoom.Location = new System.Drawing.Point(379, 18);
            this.lstRoom.Name = "lstRoom";
            this.lstRoom.Size = new System.Drawing.Size(366, 324);
            this.lstRoom.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(14, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "De Usuario 1 a Usuario 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(760, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "De Usuario 2 a Usuario 1";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(763, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(342, 22);
            this.textBox2.TabIndex = 3;
            // 
            // btnEnviarA2
            // 
            this.btnEnviarA2.Location = new System.Drawing.Point(15, 60);
            this.btnEnviarA2.Name = "btnEnviarA2";
            this.btnEnviarA2.Size = new System.Drawing.Size(335, 43);
            this.btnEnviarA2.TabIndex = 5;
            this.btnEnviarA2.Text = "Enviar";
            this.btnEnviarA2.UseVisualStyleBackColor = true;
            this.btnEnviarA2.Click += new System.EventHandler(this.btnEnviarA2_Click);
            // 
            // btnEnviarA1
            // 
            this.btnEnviarA1.Location = new System.Drawing.Point(763, 60);
            this.btnEnviarA1.Name = "btnEnviarA1";
            this.btnEnviarA1.Size = new System.Drawing.Size(342, 43);
            this.btnEnviarA1.TabIndex = 6;
            this.btnEnviarA1.Text = "Enviar";
            this.btnEnviarA1.UseVisualStyleBackColor = true;
            this.btnEnviarA1.Click += new System.EventHandler(this.btnEnviarA1_Click);
            // 
            // lstMensajesU2
            // 
            this.lstMensajesU2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMensajesU2.FormattingEnabled = true;
            this.lstMensajesU2.ItemHeight = 16;
            this.lstMensajesU2.Location = new System.Drawing.Point(763, 109);
            this.lstMensajesU2.Name = "lstMensajesU2";
            this.lstMensajesU2.Size = new System.Drawing.Size(342, 228);
            this.lstMensajesU2.TabIndex = 7;
            // 
            // lstMensajesU1
            // 
            this.lstMensajesU1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMensajesU1.FormattingEnabled = true;
            this.lstMensajesU1.ItemHeight = 16;
            this.lstMensajesU1.Location = new System.Drawing.Point(14, 109);
            this.lstMensajesU1.Name = "lstMensajesU1";
            this.lstMensajesU1.Size = new System.Drawing.Size(336, 228);
            this.lstMensajesU1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 363);
            this.Controls.Add(this.lstMensajesU1);
            this.Controls.Add(this.lstMensajesU2);
            this.Controls.Add(this.btnEnviarA1);
            this.Controls.Add(this.btnEnviarA2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstRoom);
            this.Name = "Form1";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRoom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnEnviarA2;
        private System.Windows.Forms.Button btnEnviarA1;
        private System.Windows.Forms.ListBox lstMensajesU2;
        private System.Windows.Forms.ListBox lstMensajesU1;
    }
}

