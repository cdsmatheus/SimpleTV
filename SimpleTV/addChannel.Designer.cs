
namespace SimpleTV
{
    partial class addChannel
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
            this.btnAddChannel = new System.Windows.Forms.Button();
            this.txtChannelName = new System.Windows.Forms.TextBox();
            this.txtChannelURL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddChannel
            // 
            this.btnAddChannel.Location = new System.Drawing.Point(91, 144);
            this.btnAddChannel.Name = "btnAddChannel";
            this.btnAddChannel.Size = new System.Drawing.Size(157, 41);
            this.btnAddChannel.TabIndex = 0;
            this.btnAddChannel.Text = "Adicionar Canal";
            this.btnAddChannel.UseVisualStyleBackColor = true;
            this.btnAddChannel.Click += new System.EventHandler(this.btnAddChannel_Click);
            // 
            // txtChannelName
            // 
            this.txtChannelName.Location = new System.Drawing.Point(136, 28);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Size = new System.Drawing.Size(235, 20);
            this.txtChannelName.TabIndex = 1;
            // 
            // txtChannelURL
            // 
            this.txtChannelURL.Location = new System.Drawing.Point(136, 85);
            this.txtChannelURL.Name = "txtChannelURL";
            this.txtChannelURL.Size = new System.Drawing.Size(235, 20);
            this.txtChannelURL.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Canal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "URL";
            // 
            // addChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 206);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChannelURL);
            this.Controls.Add(this.txtChannelName);
            this.Controls.Add(this.btnAddChannel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(407, 245);
            this.MinimumSize = new System.Drawing.Size(407, 245);
            this.Name = "addChannel";
            this.Text = "Adicionar Canal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddChannel;
        private System.Windows.Forms.TextBox txtChannelName;
        private System.Windows.Forms.TextBox txtChannelURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}