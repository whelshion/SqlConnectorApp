namespace WinFormApp
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.msgBox = new System.Windows.Forms.TextBox();
            this.mySqlBtn = new System.Windows.Forms.Button();
            this.msSqlBtn = new System.Windows.Forms.Button();
            this.oracleBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msgBox
            // 
            this.msgBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.msgBox.BackColor = System.Drawing.SystemColors.Info;
            this.msgBox.ForeColor = System.Drawing.Color.Blue;
            this.msgBox.Location = new System.Drawing.Point(13, 13);
            this.msgBox.MaxLength = 999999999;
            this.msgBox.Multiline = true;
            this.msgBox.Name = "msgBox";
            this.msgBox.ReadOnly = true;
            this.msgBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgBox.Size = new System.Drawing.Size(1220, 510);
            this.msgBox.TabIndex = 0;
            // 
            // mySqlBtn
            // 
            this.mySqlBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mySqlBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.mySqlBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mySqlBtn.Location = new System.Drawing.Point(374, 544);
            this.mySqlBtn.Name = "mySqlBtn";
            this.mySqlBtn.Size = new System.Drawing.Size(136, 34);
            this.mySqlBtn.TabIndex = 1;
            this.mySqlBtn.Text = "测试MySQL";
            this.mySqlBtn.UseVisualStyleBackColor = false;
            this.mySqlBtn.Click += new System.EventHandler(this.mySqlBtn_Click);
            // 
            // msSqlBtn
            // 
            this.msSqlBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.msSqlBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.msSqlBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msSqlBtn.Location = new System.Drawing.Point(542, 544);
            this.msSqlBtn.Name = "msSqlBtn";
            this.msSqlBtn.Size = new System.Drawing.Size(136, 34);
            this.msSqlBtn.TabIndex = 2;
            this.msSqlBtn.Text = "测试MSSQL";
            this.msSqlBtn.UseVisualStyleBackColor = false;
            this.msSqlBtn.Click += new System.EventHandler(this.msSqlBtn_Click);
            // 
            // oracleBtn
            // 
            this.oracleBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.oracleBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.oracleBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.oracleBtn.Location = new System.Drawing.Point(709, 544);
            this.oracleBtn.Name = "oracleBtn";
            this.oracleBtn.Size = new System.Drawing.Size(136, 34);
            this.oracleBtn.TabIndex = 3;
            this.oracleBtn.Text = "测试Oracle";
            this.oracleBtn.UseVisualStyleBackColor = false;
            this.oracleBtn.Click += new System.EventHandler(this.oracleBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearBtn.Location = new System.Drawing.Point(873, 544);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(97, 34);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "清空";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 590);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.oracleBtn);
            this.Controls.Add(this.msSqlBtn);
            this.Controls.Add(this.mySqlBtn);
            this.Controls.Add(this.msgBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 500);
            this.Name = "MainForm";
            this.Text = "SQL连接测试工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msgBox;
        private System.Windows.Forms.Button mySqlBtn;
        private System.Windows.Forms.Button msSqlBtn;
        private System.Windows.Forms.Button oracleBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

