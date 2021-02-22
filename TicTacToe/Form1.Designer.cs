
namespace TicTacToe
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnComputer = new System.Windows.Forms.Button();
            this.gbTiles = new System.Windows.Forms.GroupBox();
            this.timerDrawTiles = new System.Windows.Forms.Timer(this.components);
            this.lblResult = new System.Windows.Forms.Label();
            this.timerPause1Sec = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(33, 17);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(42, 13);
            this.lblTurn.TabIndex = 0;
            this.lblTurn.Text = "Turn: X";
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(134, 17);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(55, 13);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "X 00:00 O";
            // 
            // btnComputer
            // 
            this.btnComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComputer.BackColor = System.Drawing.Color.Red;
            this.btnComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputer.Location = new System.Drawing.Point(218, 12);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(94, 23);
            this.btnComputer.TabIndex = 2;
            this.btnComputer.Text = "Computer Player";
            this.btnComputer.UseVisualStyleBackColor = false;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // gbTiles
            // 
            this.gbTiles.AutoSize = true;
            this.gbTiles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbTiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbTiles.Location = new System.Drawing.Point(17, 54);
            this.gbTiles.Name = "gbTiles";
            this.gbTiles.Size = new System.Drawing.Size(6, 19);
            this.gbTiles.TabIndex = 3;
            this.gbTiles.TabStop = false;
            this.gbTiles.Text = "0";
            // 
            // timerDrawTiles
            // 
            this.timerDrawTiles.Interval = 3000;
            this.timerDrawTiles.Tick += new System.EventHandler(this.timerDrawTiles_Tick);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(69, 159);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(192, 63);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "DRAW";
            this.lblResult.Visible = false;
            // 
            // timerPause1Sec
            // 
            this.timerPause1Sec.Tick += new System.EventHandler(this.timerPause1Sec_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(335, 221);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.gbTiles);
            this.Controls.Add(this.btnComputer);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblTurn);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.GroupBox gbTiles;
        private System.Windows.Forms.Timer timerDrawTiles;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Timer timerPause1Sec;
    }
}

