namespace TCP_Forwarding_Tool
{
    partial class tfMainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tfMainForm));
            this.client1GB = new System.Windows.Forms.GroupBox();
            this.revHexTB1 = new System.Windows.Forms.TextBox();
            this.revMsgTB1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.client2GB = new System.Windows.Forms.GroupBox();
            this.revHexTB2 = new System.Windows.Forms.TextBox();
            this.revMsgTB2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.portTB = new System.Windows.Forms.TextBox();
            this.startNetBtn = new System.Windows.Forms.Button();
            this.displayTimer = new System.Windows.Forms.Timer(this.components);
            this.clearBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.client1GB.SuspendLayout();
            this.client2GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // client1GB
            // 
            this.client1GB.Controls.Add(this.label5);
            this.client1GB.Controls.Add(this.revHexTB1);
            this.client1GB.Controls.Add(this.revMsgTB1);
            this.client1GB.Controls.Add(this.label2);
            this.client1GB.Location = new System.Drawing.Point(12, 34);
            this.client1GB.Name = "client1GB";
            this.client1GB.Size = new System.Drawing.Size(343, 298);
            this.client1GB.TabIndex = 4;
            this.client1GB.TabStop = false;
            this.client1GB.Text = "Client1：None";
            // 
            // revHexTB1
            // 
            this.revHexTB1.Location = new System.Drawing.Point(9, 173);
            this.revHexTB1.Multiline = true;
            this.revHexTB1.Name = "revHexTB1";
            this.revHexTB1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.revHexTB1.Size = new System.Drawing.Size(328, 119);
            this.revHexTB1.TabIndex = 2;
            // 
            // revMsgTB1
            // 
            this.revMsgTB1.Location = new System.Drawing.Point(9, 39);
            this.revMsgTB1.Multiline = true;
            this.revMsgTB1.Name = "revMsgTB1";
            this.revMsgTB1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.revMsgTB1.Size = new System.Drawing.Size(328, 111);
            this.revMsgTB1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Received Message：";
            // 
            // client2GB
            // 
            this.client2GB.Controls.Add(this.label4);
            this.client2GB.Controls.Add(this.revHexTB2);
            this.client2GB.Controls.Add(this.revMsgTB2);
            this.client2GB.Controls.Add(this.label3);
            this.client2GB.Location = new System.Drawing.Point(359, 34);
            this.client2GB.Name = "client2GB";
            this.client2GB.Size = new System.Drawing.Size(343, 298);
            this.client2GB.TabIndex = 5;
            this.client2GB.TabStop = false;
            this.client2GB.Text = "Client2：None";
            // 
            // revHexTB2
            // 
            this.revHexTB2.Location = new System.Drawing.Point(8, 173);
            this.revHexTB2.Multiline = true;
            this.revHexTB2.Name = "revHexTB2";
            this.revHexTB2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.revHexTB2.Size = new System.Drawing.Size(329, 119);
            this.revHexTB2.TabIndex = 2;
            // 
            // revMsgTB2
            // 
            this.revMsgTB2.Location = new System.Drawing.Point(8, 39);
            this.revMsgTB2.Multiline = true;
            this.revMsgTB2.Name = "revMsgTB2";
            this.revMsgTB2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.revMsgTB2.Size = new System.Drawing.Size(329, 111);
            this.revMsgTB2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Received Message：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port：";
            // 
            // portTB
            // 
            this.portTB.Location = new System.Drawing.Point(49, 6);
            this.portTB.Name = "portTB";
            this.portTB.Size = new System.Drawing.Size(87, 21);
            this.portTB.TabIndex = 7;
            this.portTB.Text = "11653";
            // 
            // startNetBtn
            // 
            this.startNetBtn.Location = new System.Drawing.Point(142, 3);
            this.startNetBtn.Name = "startNetBtn";
            this.startNetBtn.Size = new System.Drawing.Size(75, 25);
            this.startNetBtn.TabIndex = 8;
            this.startNetBtn.Text = "Start";
            this.startNetBtn.UseVisualStyleBackColor = true;
            this.startNetBtn.Click += new System.EventHandler(this.startNetBtn_Click);
            // 
            // displayTimer
            // 
            this.displayTimer.Tick += new System.EventHandler(this.displayTimer_Tick);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(635, 9);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(61, 22);
            this.clearBtn.TabIndex = 9;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "HEX";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "HEX";
            // 
            // tfMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 344);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.startNetBtn);
            this.Controls.Add(this.portTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.client2GB);
            this.Controls.Add(this.client1GB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(730, 382);
            this.MinimumSize = new System.Drawing.Size(730, 382);
            this.Name = "tfMainForm";
            this.Text = "TCP Forwarding Tool";
            this.client1GB.ResumeLayout(false);
            this.client1GB.PerformLayout();
            this.client2GB.ResumeLayout(false);
            this.client2GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox client1GB;
        private System.Windows.Forms.TextBox revHexTB1;
        private System.Windows.Forms.TextBox revMsgTB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox client2GB;
        private System.Windows.Forms.TextBox revHexTB2;
        private System.Windows.Forms.TextBox revMsgTB2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portTB;
        private System.Windows.Forms.Button startNetBtn;
        private System.Windows.Forms.Timer displayTimer;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

