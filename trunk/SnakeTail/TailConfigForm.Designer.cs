﻿#region License statement
/* SnakeTail is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, version 3 of the License.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
#endregion

namespace SnakeTail
{
    partial class TailConfigForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.ColumnHeader _keywordColumn;
            this._tabControl = new System.Windows.Forms.TabControl();
            this._tabPageView = new System.Windows.Forms.TabPage();
            this._windowIconEdt = new System.Windows.Forms.TextBox();
            this._windowTitleEdt = new System.Windows.Forms.TextBox();
            this._backColorBtn = new System.Windows.Forms.Button();
            this._textColorBtn = new System.Windows.Forms.Button();
            this._tabPageFile = new System.Windows.Forms.TabPage();
            this._windowServiceEdt = new System.Windows.Forms.TextBox();
            this._fileCacheSizeEdt = new System.Windows.Forms.TextBox();
            this._fileEncodingCmb = new System.Windows.Forms.ComboBox();
            this._filePathEdt = new System.Windows.Forms.TextBox();
            this._tabPageKeyWords = new System.Windows.Forms.TabPage();
            this._delWordBtn = new System.Windows.Forms.Button();
            this._edtWordBtn = new System.Windows.Forms.Button();
            this._addWordBtn = new System.Windows.Forms.Button();
            this._keywordListView = new System.Windows.Forms.ListView();
            this._caseColumn = new System.Windows.Forms.ColumnHeader();
            this._regexColumn = new System.Windows.Forms.ColumnHeader();
            this._loghitColumn = new System.Windows.Forms.ColumnHeader();
            this._acceptBtn = new System.Windows.Forms.Button();
            this._cancelBtn = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            _keywordColumn = new System.Windows.Forms.ColumnHeader();
            this._tabControl.SuspendLayout();
            this._tabPageView.SuspendLayout();
            this._tabPageFile.SuspendLayout();
            this._tabPageKeyWords.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 46);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 13);
            label2.TabIndex = 13;
            label2.Text = "Window Icon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 13);
            label1.TabIndex = 11;
            label1.Text = "Window Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 9);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(48, 13);
            label3.TabIndex = 1;
            label3.Text = "File Path";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(3, 35);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(71, 13);
            label4.TabIndex = 3;
            label4.Text = "File Encoding";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(3, 63);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(80, 13);
            label5.TabIndex = 4;
            label5.Text = "File Cache Size";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(7, 89);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(90, 13);
            label7.TabIndex = 9;
            label7.Text = "Windows Service";
            // 
            // _keywordColumn
            // 
            _keywordColumn.Text = "Keyword";
            _keywordColumn.Width = 83;
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._tabPageView);
            this._tabControl.Controls.Add(this._tabPageFile);
            this._tabControl.Controls.Add(this._tabPageKeyWords);
            this._tabControl.Location = new System.Drawing.Point(6, 6);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(367, 198);
            this._tabControl.TabIndex = 8;
            // 
            // _tabPageView
            // 
            this._tabPageView.Controls.Add(label2);
            this._tabPageView.Controls.Add(this._windowIconEdt);
            this._tabPageView.Controls.Add(label1);
            this._tabPageView.Controls.Add(this._windowTitleEdt);
            this._tabPageView.Controls.Add(this._backColorBtn);
            this._tabPageView.Controls.Add(this._textColorBtn);
            this._tabPageView.Location = new System.Drawing.Point(4, 22);
            this._tabPageView.Name = "_tabPageView";
            this._tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageView.Size = new System.Drawing.Size(359, 172);
            this._tabPageView.TabIndex = 0;
            this._tabPageView.Text = "View";
            this._tabPageView.UseVisualStyleBackColor = true;
            // 
            // _windowIconEdt
            // 
            this._windowIconEdt.Location = new System.Drawing.Point(84, 43);
            this._windowIconEdt.Name = "_windowIconEdt";
            this._windowIconEdt.Size = new System.Drawing.Size(269, 20);
            this._windowIconEdt.TabIndex = 2;
            // 
            // _windowTitleEdt
            // 
            this._windowTitleEdt.Location = new System.Drawing.Point(84, 13);
            this._windowTitleEdt.Name = "_windowTitleEdt";
            this._windowTitleEdt.Size = new System.Drawing.Size(115, 20);
            this._windowTitleEdt.TabIndex = 1;
            // 
            // _backColorBtn
            // 
            this._backColorBtn.Location = new System.Drawing.Point(11, 98);
            this._backColorBtn.Name = "_backColorBtn";
            this._backColorBtn.Size = new System.Drawing.Size(125, 23);
            this._backColorBtn.TabIndex = 4;
            this._backColorBtn.Text = "Background Color";
            this._backColorBtn.UseVisualStyleBackColor = true;
            this._backColorBtn.Click += new System.EventHandler(this._backColorBtn_Click);
            // 
            // _textColorBtn
            // 
            this._textColorBtn.Location = new System.Drawing.Point(11, 69);
            this._textColorBtn.Name = "_textColorBtn";
            this._textColorBtn.Size = new System.Drawing.Size(125, 23);
            this._textColorBtn.TabIndex = 3;
            this._textColorBtn.Text = "Text Color and Font";
            this._textColorBtn.UseVisualStyleBackColor = true;
            this._textColorBtn.Click += new System.EventHandler(this._textColorBtn_Click);
            // 
            // _tabPageFile
            // 
            this._tabPageFile.Controls.Add(label7);
            this._tabPageFile.Controls.Add(this._windowServiceEdt);
            this._tabPageFile.Controls.Add(this._fileCacheSizeEdt);
            this._tabPageFile.Controls.Add(label5);
            this._tabPageFile.Controls.Add(label4);
            this._tabPageFile.Controls.Add(this._fileEncodingCmb);
            this._tabPageFile.Controls.Add(label3);
            this._tabPageFile.Controls.Add(this._filePathEdt);
            this._tabPageFile.Location = new System.Drawing.Point(4, 22);
            this._tabPageFile.Name = "_tabPageFile";
            this._tabPageFile.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageFile.Size = new System.Drawing.Size(359, 172);
            this._tabPageFile.TabIndex = 1;
            this._tabPageFile.Text = "Log File";
            this._tabPageFile.UseVisualStyleBackColor = true;
            // 
            // _windowServiceEdt
            // 
            this._windowServiceEdt.Location = new System.Drawing.Point(103, 86);
            this._windowServiceEdt.Name = "_windowServiceEdt";
            this._windowServiceEdt.Size = new System.Drawing.Size(100, 20);
            this._windowServiceEdt.TabIndex = 8;
            // 
            // _fileCacheSizeEdt
            // 
            this._fileCacheSizeEdt.Location = new System.Drawing.Point(103, 60);
            this._fileCacheSizeEdt.Name = "_fileCacheSizeEdt";
            this._fileCacheSizeEdt.Size = new System.Drawing.Size(100, 20);
            this._fileCacheSizeEdt.TabIndex = 5;
            // 
            // _fileEncodingCmb
            // 
            this._fileEncodingCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._fileEncodingCmb.FormattingEnabled = true;
            this._fileEncodingCmb.Location = new System.Drawing.Point(103, 32);
            this._fileEncodingCmb.Name = "_fileEncodingCmb";
            this._fileEncodingCmb.Size = new System.Drawing.Size(250, 21);
            this._fileEncodingCmb.TabIndex = 2;
            // 
            // _filePathEdt
            // 
            this._filePathEdt.Location = new System.Drawing.Point(103, 6);
            this._filePathEdt.Name = "_filePathEdt";
            this._filePathEdt.Size = new System.Drawing.Size(250, 20);
            this._filePathEdt.TabIndex = 0;
            // 
            // _tabPageKeyWords
            // 
            this._tabPageKeyWords.Controls.Add(this._delWordBtn);
            this._tabPageKeyWords.Controls.Add(this._edtWordBtn);
            this._tabPageKeyWords.Controls.Add(this._addWordBtn);
            this._tabPageKeyWords.Controls.Add(this._keywordListView);
            this._tabPageKeyWords.Location = new System.Drawing.Point(4, 22);
            this._tabPageKeyWords.Name = "_tabPageKeyWords";
            this._tabPageKeyWords.Padding = new System.Windows.Forms.Padding(3);
            this._tabPageKeyWords.Size = new System.Drawing.Size(359, 172);
            this._tabPageKeyWords.TabIndex = 2;
            this._tabPageKeyWords.Text = "Keyword Highlight";
            this._tabPageKeyWords.UseVisualStyleBackColor = true;
            // 
            // _delWordBtn
            // 
            this._delWordBtn.Location = new System.Drawing.Point(276, 64);
            this._delWordBtn.Name = "_delWordBtn";
            this._delWordBtn.Size = new System.Drawing.Size(75, 23);
            this._delWordBtn.TabIndex = 4;
            this._delWordBtn.Text = "Remove";
            this._delWordBtn.UseVisualStyleBackColor = true;
            this._delWordBtn.Click += new System.EventHandler(this._delWordBtn_Click);
            // 
            // _edtWordBtn
            // 
            this._edtWordBtn.Location = new System.Drawing.Point(276, 35);
            this._edtWordBtn.Name = "_edtWordBtn";
            this._edtWordBtn.Size = new System.Drawing.Size(75, 23);
            this._edtWordBtn.TabIndex = 3;
            this._edtWordBtn.Text = "Edit...";
            this._edtWordBtn.UseVisualStyleBackColor = true;
            this._edtWordBtn.Click += new System.EventHandler(this._edtWordBtn_Click);
            // 
            // _addWordBtn
            // 
            this._addWordBtn.Location = new System.Drawing.Point(276, 6);
            this._addWordBtn.Name = "_addWordBtn";
            this._addWordBtn.Size = new System.Drawing.Size(75, 23);
            this._addWordBtn.TabIndex = 2;
            this._addWordBtn.Text = "Add...";
            this._addWordBtn.UseVisualStyleBackColor = true;
            this._addWordBtn.Click += new System.EventHandler(this._addWordBtn_Click);
            // 
            // _keywordListView
            // 
            this._keywordListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._keywordListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            _keywordColumn,
            this._caseColumn,
            this._regexColumn,
            this._loghitColumn});
            this._keywordListView.FullRowSelect = true;
            this._keywordListView.HideSelection = false;
            this._keywordListView.Location = new System.Drawing.Point(6, 6);
            this._keywordListView.MultiSelect = false;
            this._keywordListView.Name = "_keywordListView";
            this._keywordListView.Size = new System.Drawing.Size(264, 160);
            this._keywordListView.TabIndex = 0;
            this._keywordListView.UseCompatibleStateImageBehavior = false;
            this._keywordListView.View = System.Windows.Forms.View.Details;
            this._keywordListView.DoubleClick += new System.EventHandler(this._edtWordBtn_Click);
            // 
            // _caseColumn
            // 
            this._caseColumn.Text = "Case Sensitive";
            // 
            // _regexColumn
            // 
            this._regexColumn.Text = "RegEx Match";
            // 
            // _loghitColumn
            // 
            this._loghitColumn.Text = "Log Hit";
            // 
            // _acceptBtn
            // 
            this._acceptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._acceptBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._acceptBtn.Location = new System.Drawing.Point(197, 209);
            this._acceptBtn.Name = "_acceptBtn";
            this._acceptBtn.Size = new System.Drawing.Size(75, 23);
            this._acceptBtn.TabIndex = 14;
            this._acceptBtn.Text = "OK";
            this._acceptBtn.UseVisualStyleBackColor = true;
            this._acceptBtn.Click += new System.EventHandler(this._acceptBtn_Click);
            // 
            // _cancelBtn
            // 
            this._cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._cancelBtn.Location = new System.Drawing.Point(289, 209);
            this._cancelBtn.Name = "_cancelBtn";
            this._cancelBtn.Size = new System.Drawing.Size(75, 23);
            this._cancelBtn.TabIndex = 15;
            this._cancelBtn.Text = "Cancel";
            this._cancelBtn.UseVisualStyleBackColor = true;
            // 
            // TailConfigForm
            // 
            this.AcceptButton = this._acceptBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._cancelBtn;
            this.ClientSize = new System.Drawing.Size(376, 235);
            this.Controls.Add(this._cancelBtn);
            this.Controls.Add(this._acceptBtn);
            this.Controls.Add(this._tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TailConfigForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configure View";
            this.Load += new System.EventHandler(this.TailConfigForm_Load);
            this._tabControl.ResumeLayout(false);
            this._tabPageView.ResumeLayout(false);
            this._tabPageView.PerformLayout();
            this._tabPageFile.ResumeLayout(false);
            this._tabPageFile.PerformLayout();
            this._tabPageKeyWords.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tabControl;
        private System.Windows.Forms.TabPage _tabPageView;
        private System.Windows.Forms.TextBox _windowIconEdt;
        private System.Windows.Forms.TextBox _windowTitleEdt;
        private System.Windows.Forms.Button _backColorBtn;
        private System.Windows.Forms.Button _textColorBtn;
        private System.Windows.Forms.TabPage _tabPageFile;
        private System.Windows.Forms.ComboBox _fileEncodingCmb;
        private System.Windows.Forms.TextBox _filePathEdt;
        private System.Windows.Forms.TextBox _fileCacheSizeEdt;
        private System.Windows.Forms.TextBox _windowServiceEdt;
        private System.Windows.Forms.Button _acceptBtn;
        private System.Windows.Forms.Button _cancelBtn;
        private System.Windows.Forms.TabPage _tabPageKeyWords;
        private System.Windows.Forms.ListView _keywordListView;
        private System.Windows.Forms.Button _edtWordBtn;
        private System.Windows.Forms.Button _addWordBtn;
        private System.Windows.Forms.Button _delWordBtn;
        private System.Windows.Forms.ColumnHeader _caseColumn;
        private System.Windows.Forms.ColumnHeader _regexColumn;
        private System.Windows.Forms.ColumnHeader _loghitColumn;



    }
}