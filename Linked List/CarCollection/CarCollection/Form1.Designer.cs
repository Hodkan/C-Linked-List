namespace CarCollection
{
    partial class Form1
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
            this.buttonAdd_First = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.textBoxCarName = new System.Windows.Forms.TextBox();
            this.buttonAdd_Last = new System.Windows.Forms.Button();
            this.buttonAdd_Before = new System.Windows.Forms.Button();
            this.buttonAdd_After = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxNodePosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumOfNodes = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd_First
            // 
            this.buttonAdd_First.Location = new System.Drawing.Point(182, 69);
            this.buttonAdd_First.Name = "buttonAdd_First";
            this.buttonAdd_First.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd_First.TabIndex = 0;
            this.buttonAdd_First.Text = "Add First";
            this.buttonAdd_First.UseVisualStyleBackColor = true;
            this.buttonAdd_First.Click += new System.EventHandler(this.buttonAdd_First_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(12, 38);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(120, 95);
            this.listBoxOutput.TabIndex = 1;
            // 
            // textBoxCarName
            // 
            this.textBoxCarName.Location = new System.Drawing.Point(171, 38);
            this.textBoxCarName.Name = "textBoxCarName";
            this.textBoxCarName.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarName.TabIndex = 2;
            // 
            // buttonAdd_Last
            // 
            this.buttonAdd_Last.Location = new System.Drawing.Point(182, 98);
            this.buttonAdd_Last.Name = "buttonAdd_Last";
            this.buttonAdd_Last.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd_Last.TabIndex = 3;
            this.buttonAdd_Last.Text = "Add Last";
            this.buttonAdd_Last.UseVisualStyleBackColor = true;
            this.buttonAdd_Last.Click += new System.EventHandler(this.buttonAdd_Last_Click);
            // 
            // buttonAdd_Before
            // 
            this.buttonAdd_Before.Location = new System.Drawing.Point(372, 69);
            this.buttonAdd_Before.Name = "buttonAdd_Before";
            this.buttonAdd_Before.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd_Before.TabIndex = 4;
            this.buttonAdd_Before.Text = "Add Before";
            this.buttonAdd_Before.UseVisualStyleBackColor = true;
            this.buttonAdd_Before.Click += new System.EventHandler(this.buttonAdd_Before_Click);
            // 
            // buttonAdd_After
            // 
            this.buttonAdd_After.Location = new System.Drawing.Point(372, 98);
            this.buttonAdd_After.Name = "buttonAdd_After";
            this.buttonAdd_After.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd_After.TabIndex = 5;
            this.buttonAdd_After.Text = "Add After";
            this.buttonAdd_After.UseVisualStyleBackColor = true;
            this.buttonAdd_After.Click += new System.EventHandler(this.buttonAdd_After_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(29, 155);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(29, 188);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxNodePosition
            // 
            this.textBoxNodePosition.Location = new System.Drawing.Point(358, 38);
            this.textBoxNodePosition.Name = "textBoxNodePosition";
            this.textBoxNodePosition.Size = new System.Drawing.Size(100, 20);
            this.textBoxNodePosition.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Car Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Node Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Number Of Nodes";
            // 
            // textBoxNumOfNodes
            // 
            this.textBoxNumOfNodes.Enabled = false;
            this.textBoxNumOfNodes.Location = new System.Drawing.Point(358, 205);
            this.textBoxNumOfNodes.Name = "textBoxNumOfNodes";
            this.textBoxNumOfNodes.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumOfNodes.TabIndex = 12;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(182, 128);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 261);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxNumOfNodes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNodePosition);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd_After);
            this.Controls.Add(this.buttonAdd_Before);
            this.Controls.Add(this.buttonAdd_Last);
            this.Controls.Add(this.textBoxCarName);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.buttonAdd_First);
            this.Name = "Form1";
            this.Text = "Linked List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd_First;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.TextBox textBoxCarName;
        private System.Windows.Forms.Button buttonAdd_Last;
        private System.Windows.Forms.Button buttonAdd_Before;
        private System.Windows.Forms.Button buttonAdd_After;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxNodePosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumOfNodes;
        private System.Windows.Forms.Button buttonSearch;
    }
}

