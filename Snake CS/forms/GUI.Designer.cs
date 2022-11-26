using Snake.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace Snake
{
    partial class GUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Lädt das Haptmenü
        /// </summary>
        /// <param name="load">Menü oder Spiel laden</param>
        private void LoadMenu(bool load)
        {
            if (load)
            {
                Controls.Clear();

                #region Menu
                this.Con = new System.Windows.Forms.Button();
                this.Res = new System.Windows.Forms.Button();
                this.exit = new System.Windows.Forms.Button();
                this.cscore = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.hscore = new System.Windows.Forms.Label();
                this.SuspendLayout();
                // 
                // Con
                // 
                this.Con.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Con.Location = new System.Drawing.Point(299, 181);
                this.Con.Name = "Con";
                this.Con.Size = new System.Drawing.Size(75, 35);
                this.Con.TabIndex = 0;
                this.Con.Text = "Continue";
                this.Con.UseVisualStyleBackColor = true;
                this.Con.Click += Continue_Click;
                // 
                // Res
                // 
                this.Res.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.Res.Location = new System.Drawing.Point(299, 222);
                this.Res.Name = "Res";
                this.Res.Size = new System.Drawing.Size(75, 35);
                this.Res.TabIndex = 1;
                this.Res.Text = "Restart";
                this.Res.UseVisualStyleBackColor = true;
                this.Res.Click += Restart_Click;
                // 
                // exit
                // 
                this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.exit.Location = new System.Drawing.Point(299, 263);
                this.exit.Name = "exit";
                this.exit.Size = new System.Drawing.Size(75, 35);
                this.exit.TabIndex = 2;
                this.exit.Text = "Exit";
                this.exit.UseVisualStyleBackColor = true;
                this.exit.Click += Exit_Click;
                // 
                // cscore
                // 
                this.cscore.AutoSize = true;
                this.cscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.cscore.Location = new System.Drawing.Point(271, 138);
                this.cscore.Name = "score";
                this.cscore.Size = new System.Drawing.Size(140, 20);
                this.cscore.TabIndex = 3;
                this.cscore.Text = $"You have {score} points!";
                // 
                // label2
                // 
                this.label2.AutoSize = true;
                this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label2.Location = new System.Drawing.Point(293, 96);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(91, 33);
                this.label2.TabIndex = 4;
                this.label2.Text = "Menu";
                // 
                // hscore
                // 
                this.hscore.AutoSize = true;
                this.hscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.hscore.Location = new System.Drawing.Point(227, 158);
                this.hscore.Name = "hscore";
                this.hscore.Size = new System.Drawing.Size(234, 20);
                this.hscore.TabIndex = 5;
                this.hscore.Text = "Programm highscore is 0 points!";
                // 
                // GUI
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.CadetBlue;
                this.ClientSize = new System.Drawing.Size(644, 649);
                this.Controls.Add(this.hscore);
                this.Controls.Add(this.label2);
                this.Controls.Add(this.cscore);
                this.Controls.Add(this.exit);
                this.Controls.Add(this.Res);
                this.Controls.Add(this.Con);
                this.MaximizeBox = false;
                this.MinimizeBox = false;
                this.MaximumSize = new System.Drawing.Size(660, 688);
                this.MinimumSize = new System.Drawing.Size(660, 688);
                this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GUI_KeyDown);
                this.Name = "GUI";
                this.Text = "Snake";
                this.ResumeLayout(false);
                this.PerformLayout();
                #endregion

                // lädt / setzt high score                
                cscore.Text = $"You have {score} points!";

                if (score > Settings.Default.hscore)
                {
                    Settings.Default.hscore = score;
                    Settings.Default.Save();
                }
                hscore.Text = $"Programm highscore is {Settings.Default.hscore} points!";
            }
            else
            {
                Controls.Clear();
                InitializeComponent();
            }
        }

        private System.Windows.Forms.Button Con;
        private System.Windows.Forms.Button Res;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label cscore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label hscore;

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(GUI));
            this.field = new System.Windows.Forms.TableLayoutPanel();
            this.panel100 = new System.Windows.Forms.Panel();
            this.panel99 = new System.Windows.Forms.Panel();
            this.panel98 = new System.Windows.Forms.Panel();
            this.panel97 = new System.Windows.Forms.Panel();
            this.panel96 = new System.Windows.Forms.Panel();
            this.panel95 = new System.Windows.Forms.Panel();
            this.panel94 = new System.Windows.Forms.Panel();
            this.panel93 = new System.Windows.Forms.Panel();
            this.panel92 = new System.Windows.Forms.Panel();
            this.panel91 = new System.Windows.Forms.Panel();
            this.panel90 = new System.Windows.Forms.Panel();
            this.panel89 = new System.Windows.Forms.Panel();
            this.panel88 = new System.Windows.Forms.Panel();
            this.panel87 = new System.Windows.Forms.Panel();
            this.panel86 = new System.Windows.Forms.Panel();
            this.panel85 = new System.Windows.Forms.Panel();
            this.panel84 = new System.Windows.Forms.Panel();
            this.panel83 = new System.Windows.Forms.Panel();
            this.panel82 = new System.Windows.Forms.Panel();
            this.panel81 = new System.Windows.Forms.Panel();
            this.panel80 = new System.Windows.Forms.Panel();
            this.panel79 = new System.Windows.Forms.Panel();
            this.panel78 = new System.Windows.Forms.Panel();
            this.panel77 = new System.Windows.Forms.Panel();
            this.panel76 = new System.Windows.Forms.Panel();
            this.panel75 = new System.Windows.Forms.Panel();
            this.panel74 = new System.Windows.Forms.Panel();
            this.panel73 = new System.Windows.Forms.Panel();
            this.panel72 = new System.Windows.Forms.Panel();
            this.panel71 = new System.Windows.Forms.Panel();
            this.panel70 = new System.Windows.Forms.Panel();
            this.panel69 = new System.Windows.Forms.Panel();
            this.panel68 = new System.Windows.Forms.Panel();
            this.panel67 = new System.Windows.Forms.Panel();
            this.panel66 = new System.Windows.Forms.Panel();
            this.panel65 = new System.Windows.Forms.Panel();
            this.panel64 = new System.Windows.Forms.Panel();
            this.panel63 = new System.Windows.Forms.Panel();
            this.panel62 = new System.Windows.Forms.Panel();
            this.panel61 = new System.Windows.Forms.Panel();
            this.panel60 = new System.Windows.Forms.Panel();
            this.panel59 = new System.Windows.Forms.Panel();
            this.panel58 = new System.Windows.Forms.Panel();
            this.panel57 = new System.Windows.Forms.Panel();
            this.panel56 = new System.Windows.Forms.Panel();
            this.panel55 = new System.Windows.Forms.Panel();
            this.panel54 = new System.Windows.Forms.Panel();
            this.panel53 = new System.Windows.Forms.Panel();
            this.panel52 = new System.Windows.Forms.Panel();
            this.panel51 = new System.Windows.Forms.Panel();
            this.panel50 = new System.Windows.Forms.Panel();
            this.panel49 = new System.Windows.Forms.Panel();
            this.panel48 = new System.Windows.Forms.Panel();
            this.panel47 = new System.Windows.Forms.Panel();
            this.panel46 = new System.Windows.Forms.Panel();
            this.panel45 = new System.Windows.Forms.Panel();
            this.panel44 = new System.Windows.Forms.Panel();
            this.panel43 = new System.Windows.Forms.Panel();
            this.panel42 = new System.Windows.Forms.Panel();
            this.panel41 = new System.Windows.Forms.Panel();
            this.panel40 = new System.Windows.Forms.Panel();
            this.panel39 = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.panel37 = new System.Windows.Forms.Panel();
            this.panel36 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.field.SuspendLayout();
            this.SuspendLayout();
            // 
            // field
            // 
            this.field.BackColor = System.Drawing.Color.Snow;
            resources.ApplyResources(this.field, "field");
            this.field.Controls.Add(this.panel100, 9, 9);
            this.field.Controls.Add(this.panel99, 8, 9);
            this.field.Controls.Add(this.panel98, 7, 9);
            this.field.Controls.Add(this.panel97, 6, 9);
            this.field.Controls.Add(this.panel96, 5, 9);
            this.field.Controls.Add(this.panel95, 4, 9);
            this.field.Controls.Add(this.panel94, 3, 9);
            this.field.Controls.Add(this.panel93, 2, 9);
            this.field.Controls.Add(this.panel92, 1, 9);
            this.field.Controls.Add(this.panel91, 0, 9);
            this.field.Controls.Add(this.panel90, 9, 8);
            this.field.Controls.Add(this.panel89, 8, 8);
            this.field.Controls.Add(this.panel88, 7, 8);
            this.field.Controls.Add(this.panel87, 6, 8);
            this.field.Controls.Add(this.panel86, 5, 8);
            this.field.Controls.Add(this.panel85, 4, 8);
            this.field.Controls.Add(this.panel84, 3, 8);
            this.field.Controls.Add(this.panel83, 2, 8);
            this.field.Controls.Add(this.panel82, 1, 8);
            this.field.Controls.Add(this.panel81, 0, 8);
            this.field.Controls.Add(this.panel80, 9, 7);
            this.field.Controls.Add(this.panel79, 8, 7);
            this.field.Controls.Add(this.panel78, 7, 7);
            this.field.Controls.Add(this.panel77, 6, 7);
            this.field.Controls.Add(this.panel76, 5, 7);
            this.field.Controls.Add(this.panel75, 4, 7);
            this.field.Controls.Add(this.panel74, 3, 7);
            this.field.Controls.Add(this.panel73, 2, 7);
            this.field.Controls.Add(this.panel72, 1, 7);
            this.field.Controls.Add(this.panel71, 0, 7);
            this.field.Controls.Add(this.panel70, 9, 6);
            this.field.Controls.Add(this.panel69, 8, 6);
            this.field.Controls.Add(this.panel68, 7, 6);
            this.field.Controls.Add(this.panel67, 6, 6);
            this.field.Controls.Add(this.panel66, 5, 6);
            this.field.Controls.Add(this.panel65, 4, 6);
            this.field.Controls.Add(this.panel64, 3, 6);
            this.field.Controls.Add(this.panel63, 2, 6);
            this.field.Controls.Add(this.panel62, 1, 6);
            this.field.Controls.Add(this.panel61, 0, 6);
            this.field.Controls.Add(this.panel60, 9, 5);
            this.field.Controls.Add(this.panel59, 8, 5);
            this.field.Controls.Add(this.panel58, 7, 5);
            this.field.Controls.Add(this.panel57, 6, 5);
            this.field.Controls.Add(this.panel56, 5, 5);
            this.field.Controls.Add(this.panel55, 4, 5);
            this.field.Controls.Add(this.panel54, 3, 5);
            this.field.Controls.Add(this.panel53, 2, 5);
            this.field.Controls.Add(this.panel52, 1, 5);
            this.field.Controls.Add(this.panel51, 0, 5);
            this.field.Controls.Add(this.panel50, 9, 4);
            this.field.Controls.Add(this.panel49, 8, 4);
            this.field.Controls.Add(this.panel48, 7, 4);
            this.field.Controls.Add(this.panel47, 6, 4);
            this.field.Controls.Add(this.panel46, 5, 4);
            this.field.Controls.Add(this.panel45, 4, 4);
            this.field.Controls.Add(this.panel44, 3, 4);
            this.field.Controls.Add(this.panel43, 2, 4);
            this.field.Controls.Add(this.panel42, 1, 4);
            this.field.Controls.Add(this.panel41, 0, 4);
            this.field.Controls.Add(this.panel40, 9, 3);
            this.field.Controls.Add(this.panel39, 8, 3);
            this.field.Controls.Add(this.panel38, 7, 3);
            this.field.Controls.Add(this.panel37, 6, 3);
            this.field.Controls.Add(this.panel36, 5, 3);
            this.field.Controls.Add(this.panel35, 4, 3);
            this.field.Controls.Add(this.panel34, 3, 3);
            this.field.Controls.Add(this.panel33, 2, 3);
            this.field.Controls.Add(this.panel32, 1, 3);
            this.field.Controls.Add(this.panel31, 0, 3);
            this.field.Controls.Add(this.panel30, 9, 2);
            this.field.Controls.Add(this.panel29, 8, 2);
            this.field.Controls.Add(this.panel28, 7, 2);
            this.field.Controls.Add(this.panel27, 6, 2);
            this.field.Controls.Add(this.panel26, 5, 2);
            this.field.Controls.Add(this.panel25, 4, 2);
            this.field.Controls.Add(this.panel24, 3, 2);
            this.field.Controls.Add(this.panel23, 2, 2);
            this.field.Controls.Add(this.panel22, 1, 2);
            this.field.Controls.Add(this.panel21, 0, 2);
            this.field.Controls.Add(this.panel20, 9, 1);
            this.field.Controls.Add(this.panel19, 8, 1);
            this.field.Controls.Add(this.panel18, 7, 1);
            this.field.Controls.Add(this.panel17, 6, 1);
            this.field.Controls.Add(this.panel16, 5, 1);
            this.field.Controls.Add(this.panel15, 4, 1);
            this.field.Controls.Add(this.panel14, 3, 1);
            this.field.Controls.Add(this.panel13, 2, 1);
            this.field.Controls.Add(this.panel12, 1, 1);
            this.field.Controls.Add(this.panel11, 0, 1);
            this.field.Controls.Add(this.panel10, 9, 0);
            this.field.Controls.Add(this.panel9, 8, 0);
            this.field.Controls.Add(this.panel8, 7, 0);
            this.field.Controls.Add(this.panel7, 6, 0);
            this.field.Controls.Add(this.panel6, 5, 0);
            this.field.Controls.Add(this.panel5, 4, 0);
            this.field.Controls.Add(this.panel4, 3, 0);
            this.field.Controls.Add(this.panel3, 2, 0);
            this.field.Controls.Add(this.panel2, 1, 0);
            this.field.Controls.Add(this.panel1, 0, 0);
            this.field.Name = "field";
            // 
            // panel100
            // 
            resources.ApplyResources(this.panel100, "panel100");
            this.panel100.Name = "panel100";
            // 
            // panel99
            // 
            resources.ApplyResources(this.panel99, "panel99");
            this.panel99.Name = "panel99";
            // 
            // panel98
            // 
            resources.ApplyResources(this.panel98, "panel98");
            this.panel98.Name = "panel98";
            // 
            // panel97
            // 
            resources.ApplyResources(this.panel97, "panel97");
            this.panel97.Name = "panel97";
            // 
            // panel96
            // 
            resources.ApplyResources(this.panel96, "panel96");
            this.panel96.Name = "panel96";
            // 
            // panel95
            // 
            resources.ApplyResources(this.panel95, "panel95");
            this.panel95.Name = "panel95";
            // 
            // panel94
            // 
            resources.ApplyResources(this.panel94, "panel94");
            this.panel94.Name = "panel94";
            // 
            // panel93
            // 
            resources.ApplyResources(this.panel93, "panel93");
            this.panel93.Name = "panel93";
            // 
            // panel92
            // 
            resources.ApplyResources(this.panel92, "panel92");
            this.panel92.Name = "panel92";
            // 
            // panel91
            // 
            resources.ApplyResources(this.panel91, "panel91");
            this.panel91.Name = "panel91";
            // 
            // panel90
            // 
            resources.ApplyResources(this.panel90, "panel90");
            this.panel90.Name = "panel90";
            // 
            // panel89
            // 
            resources.ApplyResources(this.panel89, "panel89");
            this.panel89.Name = "panel89";
            // 
            // panel88
            // 
            resources.ApplyResources(this.panel88, "panel88");
            this.panel88.Name = "panel88";
            // 
            // panel87
            // 
            resources.ApplyResources(this.panel87, "panel87");
            this.panel87.Name = "panel87";
            // 
            // panel86
            // 
            resources.ApplyResources(this.panel86, "panel86");
            this.panel86.Name = "panel86";
            // 
            // panel85
            // 
            resources.ApplyResources(this.panel85, "panel85");
            this.panel85.Name = "panel85";
            // 
            // panel84
            // 
            resources.ApplyResources(this.panel84, "panel84");
            this.panel84.Name = "panel84";
            // 
            // panel83
            // 
            resources.ApplyResources(this.panel83, "panel83");
            this.panel83.Name = "panel83";
            // 
            // panel82
            // 
            resources.ApplyResources(this.panel82, "panel82");
            this.panel82.Name = "panel82";
            // 
            // panel81
            // 
            resources.ApplyResources(this.panel81, "panel81");
            this.panel81.Name = "panel81";
            // 
            // panel80
            // 
            resources.ApplyResources(this.panel80, "panel80");
            this.panel80.Name = "panel80";
            // 
            // panel79
            // 
            resources.ApplyResources(this.panel79, "panel79");
            this.panel79.Name = "panel79";
            // 
            // panel78
            // 
            resources.ApplyResources(this.panel78, "panel78");
            this.panel78.Name = "panel78";
            // 
            // panel77
            // 
            resources.ApplyResources(this.panel77, "panel77");
            this.panel77.Name = "panel77";
            // 
            // panel76
            // 
            resources.ApplyResources(this.panel76, "panel76");
            this.panel76.Name = "panel76";
            // 
            // panel75
            // 
            resources.ApplyResources(this.panel75, "panel75");
            this.panel75.Name = "panel75";
            // 
            // panel74
            // 
            resources.ApplyResources(this.panel74, "panel74");
            this.panel74.Name = "panel74";
            // 
            // panel73
            // 
            resources.ApplyResources(this.panel73, "panel73");
            this.panel73.Name = "panel73";
            // 
            // panel72
            // 
            resources.ApplyResources(this.panel72, "panel72");
            this.panel72.Name = "panel72";
            // 
            // panel71
            // 
            resources.ApplyResources(this.panel71, "panel71");
            this.panel71.Name = "panel71";
            // 
            // panel70
            // 
            resources.ApplyResources(this.panel70, "panel70");
            this.panel70.Name = "panel70";
            // 
            // panel69
            // 
            resources.ApplyResources(this.panel69, "panel69");
            this.panel69.Name = "panel69";
            // 
            // panel68
            // 
            resources.ApplyResources(this.panel68, "panel68");
            this.panel68.Name = "panel68";
            // 
            // panel67
            // 
            resources.ApplyResources(this.panel67, "panel67");
            this.panel67.Name = "panel67";
            // 
            // panel66
            // 
            resources.ApplyResources(this.panel66, "panel66");
            this.panel66.Name = "panel66";
            // 
            // panel65
            // 
            resources.ApplyResources(this.panel65, "panel65");
            this.panel65.Name = "panel65";
            // 
            // panel64
            // 
            resources.ApplyResources(this.panel64, "panel64");
            this.panel64.Name = "panel64";
            // 
            // panel63
            // 
            resources.ApplyResources(this.panel63, "panel63");
            this.panel63.Name = "panel63";
            // 
            // panel62
            // 
            resources.ApplyResources(this.panel62, "panel62");
            this.panel62.Name = "panel62";
            // 
            // panel61
            // 
            resources.ApplyResources(this.panel61, "panel61");
            this.panel61.Name = "panel61";
            // 
            // panel60
            // 
            resources.ApplyResources(this.panel60, "panel60");
            this.panel60.Name = "panel60";
            // 
            // panel59
            // 
            resources.ApplyResources(this.panel59, "panel59");
            this.panel59.Name = "panel59";
            // 
            // panel58
            // 
            resources.ApplyResources(this.panel58, "panel58");
            this.panel58.Name = "panel58";
            // 
            // panel57
            // 
            resources.ApplyResources(this.panel57, "panel57");
            this.panel57.Name = "panel57";
            // 
            // panel56
            // 
            resources.ApplyResources(this.panel56, "panel56");
            this.panel56.Name = "panel56";
            // 
            // panel55
            // 
            resources.ApplyResources(this.panel55, "panel55");
            this.panel55.Name = "panel55";
            // 
            // panel54
            // 
            resources.ApplyResources(this.panel54, "panel54");
            this.panel54.Name = "panel54";
            // 
            // panel53
            // 
            resources.ApplyResources(this.panel53, "panel53");
            this.panel53.Name = "panel53";
            // 
            // panel52
            // 
            resources.ApplyResources(this.panel52, "panel52");
            this.panel52.Name = "panel52";
            // 
            // panel51
            // 
            resources.ApplyResources(this.panel51, "panel51");
            this.panel51.Name = "panel51";
            // 
            // panel50
            // 
            resources.ApplyResources(this.panel50, "panel50");
            this.panel50.Name = "panel50";
            // 
            // panel49
            // 
            resources.ApplyResources(this.panel49, "panel49");
            this.panel49.Name = "panel49";
            // 
            // panel48
            // 
            resources.ApplyResources(this.panel48, "panel48");
            this.panel48.Name = "panel48";
            // 
            // panel47
            // 
            resources.ApplyResources(this.panel47, "panel47");
            this.panel47.Name = "panel47";
            // 
            // panel46
            // 
            resources.ApplyResources(this.panel46, "panel46");
            this.panel46.Name = "panel46";
            // 
            // panel45
            // 
            resources.ApplyResources(this.panel45, "panel45");
            this.panel45.Name = "panel45";
            // 
            // panel44
            // 
            resources.ApplyResources(this.panel44, "panel44");
            this.panel44.Name = "panel44";
            // 
            // panel43
            // 
            resources.ApplyResources(this.panel43, "panel43");
            this.panel43.Name = "panel43";
            // 
            // panel42
            // 
            resources.ApplyResources(this.panel42, "panel42");
            this.panel42.Name = "panel42";
            // 
            // panel41
            // 
            resources.ApplyResources(this.panel41, "panel41");
            this.panel41.Name = "panel41";
            // 
            // panel40
            // 
            resources.ApplyResources(this.panel40, "panel40");
            this.panel40.Name = "panel40";
            // 
            // panel39
            // 
            resources.ApplyResources(this.panel39, "panel39");
            this.panel39.Name = "panel39";
            // 
            // panel38
            // 
            resources.ApplyResources(this.panel38, "panel38");
            this.panel38.Name = "panel38";
            // 
            // panel37
            // 
            resources.ApplyResources(this.panel37, "panel37");
            this.panel37.Name = "panel37";
            // 
            // panel36
            // 
            resources.ApplyResources(this.panel36, "panel36");
            this.panel36.Name = "panel36";
            // 
            // panel35
            // 
            resources.ApplyResources(this.panel35, "panel35");
            this.panel35.Name = "panel35";
            // 
            // panel34
            // 
            resources.ApplyResources(this.panel34, "panel34");
            this.panel34.Name = "panel34";
            // 
            // panel33
            // 
            resources.ApplyResources(this.panel33, "panel33");
            this.panel33.Name = "panel33";
            // 
            // panel32
            // 
            resources.ApplyResources(this.panel32, "panel32");
            this.panel32.Name = "panel32";
            // 
            // panel31
            // 
            resources.ApplyResources(this.panel31, "panel31");
            this.panel31.Name = "panel31";
            // 
            // panel30
            // 
            resources.ApplyResources(this.panel30, "panel30");
            this.panel30.Name = "panel30";
            // 
            // panel29
            // 
            resources.ApplyResources(this.panel29, "panel29");
            this.panel29.Name = "panel29";
            // 
            // panel28
            // 
            resources.ApplyResources(this.panel28, "panel28");
            this.panel28.Name = "panel28";
            // 
            // panel27
            // 
            resources.ApplyResources(this.panel27, "panel27");
            this.panel27.Name = "panel27";
            // 
            // panel26
            // 
            resources.ApplyResources(this.panel26, "panel26");
            this.panel26.Name = "panel26";
            // 
            // panel25
            // 
            resources.ApplyResources(this.panel25, "panel25");
            this.panel25.Name = "panel25";
            // 
            // panel24
            // 
            resources.ApplyResources(this.panel24, "panel24");
            this.panel24.Name = "panel24";
            // 
            // panel23
            // 
            resources.ApplyResources(this.panel23, "panel23");
            this.panel23.Name = "panel23";
            // 
            // panel22
            // 
            resources.ApplyResources(this.panel22, "panel22");
            this.panel22.Name = "panel22";
            // 
            // panel21
            // 
            resources.ApplyResources(this.panel21, "panel21");
            this.panel21.Name = "panel21";
            // 
            // panel20
            // 
            resources.ApplyResources(this.panel20, "panel20");
            this.panel20.Name = "panel20";
            // 
            // panel19
            // 
            resources.ApplyResources(this.panel19, "panel19");
            this.panel19.Name = "panel19";
            // 
            // panel18
            // 
            resources.ApplyResources(this.panel18, "panel18");
            this.panel18.Name = "panel18";
            // 
            // panel17
            // 
            resources.ApplyResources(this.panel17, "panel17");
            this.panel17.Name = "panel17";
            // 
            // panel16
            // 
            resources.ApplyResources(this.panel16, "panel16");
            this.panel16.Name = "panel16";
            // 
            // panel15
            // 
            resources.ApplyResources(this.panel15, "panel15");
            this.panel15.Name = "panel15";
            // 
            // panel14
            // 
            resources.ApplyResources(this.panel14, "panel14");
            this.panel14.Name = "panel14";
            // 
            // panel13
            // 
            resources.ApplyResources(this.panel13, "panel13");
            this.panel13.Name = "panel13";
            // 
            // panel12
            // 
            resources.ApplyResources(this.panel12, "panel12");
            this.panel12.Name = "panel12";
            // 
            // panel11
            // 
            resources.ApplyResources(this.panel11, "panel11");
            this.panel11.Name = "panel11";
            // 
            // panel10
            // 
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // panel9
            // 
            resources.ApplyResources(this.panel9, "panel9");
            this.panel9.Name = "panel9";
            // 
            // panel8
            // 
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.Name = "panel8";
            // 
            // panel7
            // 
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // GUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.field);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GUI";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GUI_KeyDown);
            this.field.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel field;
        private Panel panel1;
        private Panel panel10;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel100;
        private Panel panel99;
        private Panel panel98;
        private Panel panel97;
        private Panel panel96;
        private Panel panel95;
        private Panel panel94;
        private Panel panel93;
        private Panel panel92;
        private Panel panel91;
        private Panel panel90;
        private Panel panel89;
        private Panel panel88;
        private Panel panel87;
        private Panel panel86;
        private Panel panel85;
        private Panel panel84;
        private Panel panel83;
        private Panel panel82;
        private Panel panel81;
        private Panel panel80;
        private Panel panel79;
        private Panel panel78;
        private Panel panel77;
        private Panel panel76;
        private Panel panel75;
        private Panel panel74;
        private Panel panel73;
        private Panel panel72;
        private Panel panel71;
        private Panel panel70;
        private Panel panel69;
        private Panel panel68;
        private Panel panel67;
        private Panel panel66;
        private Panel panel65;
        private Panel panel64;
        private Panel panel63;
        private Panel panel62;
        private Panel panel61;
        private Panel panel60;
        private Panel panel59;
        private Panel panel58;
        private Panel panel57;
        private Panel panel56;
        private Panel panel55;
        private Panel panel54;
        private Panel panel53;
        private Panel panel52;
        private Panel panel51;
        private Panel panel50;
        private Panel panel49;
        private Panel panel48;
        private Panel panel47;
        private Panel panel46;
        private Panel panel45;
        private Panel panel44;
        private Panel panel43;
        private Panel panel42;
        private Panel panel41;
        private Panel panel40;
        private Panel panel39;
        private Panel panel38;
        private Panel panel37;
        private Panel panel36;
        private Panel panel35;
        private Panel panel34;
        private Panel panel33;
        private Panel panel32;
        private Panel panel31;
        private Panel panel30;
        private Panel panel29;
        private Panel panel28;
        private Panel panel27;
        private Panel panel26;
        private Panel panel25;
        private Panel panel24;
        private Panel panel23;
        private Panel panel22;
        private Panel panel21;
        private Panel panel20;
        private Panel panel19;
        private Panel panel18;
        private Panel panel17;
        private Panel panel16;
        private Panel panel15;
        private Panel panel14;
        private Panel panel13;
        private Panel panel12;
        private Panel panel11;
    }
}

