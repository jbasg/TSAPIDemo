﻿/*
 Copyright 2015 TSAPI.NET project

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using Tsapi;
using System.Configuration;
namespace TSAPIDemo
{
    partial class mainForm
    {
        public static System.Configuration.Configuration config  = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        public Acs.ACSHandle_t acsHandle;
        public Acs.PrivateData_t privData;

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
            this.configTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.wmEventNotifyCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.esrCheckBox = new System.Windows.Forms.CheckBox();
            this.enumServerNamesButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apiVer_textBox = new System.Windows.Forms.TextBox();
            this.appName_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.login_textBox = new System.Windows.Forms.TextBox();
            this.serverId_textBox = new System.Windows.Forms.TextBox();
            this.TestsTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cstaSetMsgWaitingIndButton = new System.Windows.Forms.Button();
            this.cstaSetForwardingButton = new System.Windows.Forms.Button();
            this.cstaSetDoNotDisturbButton = new System.Windows.Forms.Button();
            this.attSetBillRateButton = new System.Windows.Forms.Button();
            this.cstaSetAgentStateButton = new System.Windows.Forms.Button();
            this.attSetAdviceOfChargeButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cstaGetAPICapsButton = new System.Windows.Forms.Button();
            this.cstaGetDeviceListButton = new System.Windows.Forms.Button();
            this.cstaQueryCallMonitorButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.acsFlushEventQueueButton = new System.Windows.Forms.Button();
            this.acsQueryAuthInfoButton = new System.Windows.Forms.Button();
            this.acsSetHeartbeatIntervalButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cstaClearConnectionButton = new System.Windows.Forms.Button();
            this.cstaClearCallButton = new System.Windows.Forms.Button();
            this.cstaTransferCallButton = new System.Windows.Forms.Button();
            this.cstaAlternateCallButton = new System.Windows.Forms.Button();
            this.attSingleStepTransferCallButton = new System.Windows.Forms.Button();
            this.cstaAnswerCallButton = new System.Windows.Forms.Button();
            this.attSingleStepConferenceCallButton = new System.Windows.Forms.Button();
            this.cstaConferenceCallButton = new System.Windows.Forms.Button();
            this.attSelectiveListeningRetrieveButton = new System.Windows.Forms.Button();
            this.cstaConsultantCallButton = new System.Windows.Forms.Button();
            this.attSelectiveListeningHoldButton = new System.Windows.Forms.Button();
            this.deflectCallButton = new System.Windows.Forms.Button();
            this.SendDTMFToneButton = new System.Windows.Forms.Button();
            this.cstaHoldButton = new System.Windows.Forms.Button();
            this.cstaRetrieveCallButton = new System.Windows.Forms.Button();
            this.cstaMakeCallButton = new System.Windows.Forms.Button();
            this.cstaMakePredictiveCallButton = new System.Windows.Forms.Button();
            this.cstaPickupCallButton = new System.Windows.Forms.Button();
            this.cstaReconnectCallButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.streamCheckbox = new System.Windows.Forms.CheckBox();
            this.snapShotDeviceButton = new System.Windows.Forms.Button();
            this.deviceLabel = new System.Windows.Forms.Label();
            this.deviceTextBox = new System.Windows.Forms.TextBox();
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.configTab.SuspendLayout();
            this.TestsTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // configTab
            // 
            this.configTab.Controls.Add(this.label8);
            this.configTab.Controls.Add(this.wmEventNotifyCheckBox);
            this.configTab.Controls.Add(this.label1);
            this.configTab.Controls.Add(this.esrCheckBox);
            this.configTab.Controls.Add(this.enumServerNamesButton);
            this.configTab.Controls.Add(this.label6);
            this.configTab.Controls.Add(this.label5);
            this.configTab.Controls.Add(this.label4);
            this.configTab.Controls.Add(this.label3);
            this.configTab.Controls.Add(this.label2);
            this.configTab.Controls.Add(this.apiVer_textBox);
            this.configTab.Controls.Add(this.appName_textBox);
            this.configTab.Controls.Add(this.password_textBox);
            this.configTab.Controls.Add(this.login_textBox);
            this.configTab.Controls.Add(this.serverId_textBox);
            this.configTab.Location = new System.Drawing.Point(4, 22);
            this.configTab.Name = "configTab";
            this.configTab.Padding = new System.Windows.Forms.Padding(3);
            this.configTab.Size = new System.Drawing.Size(1119, 468);
            this.configTab.TabIndex = 1;
            this.configTab.Text = "Configuration";
            this.configTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "WM Event notify";
            // 
            // wmEventNotifyCheckBox
            // 
            this.wmEventNotifyCheckBox.AutoSize = true;
            this.wmEventNotifyCheckBox.Location = new System.Drawing.Point(174, 222);
            this.wmEventNotifyCheckBox.Name = "wmEventNotifyCheckBox";
            this.wmEventNotifyCheckBox.Size = new System.Drawing.Size(67, 17);
            this.wmEventNotifyCheckBox.TabIndex = 32;
            this.wmEventNotifyCheckBox.Text = "Disabled";
            this.wmEventNotifyCheckBox.UseVisualStyleBackColor = true;
            this.wmEventNotifyCheckBox.Click += new System.EventHandler(this.wmEventNotifyCheckBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "ESR Event notify";
            // 
            // esrCheckBox
            // 
            this.esrCheckBox.AutoSize = true;
            this.esrCheckBox.Location = new System.Drawing.Point(59, 222);
            this.esrCheckBox.Name = "esrCheckBox";
            this.esrCheckBox.Size = new System.Drawing.Size(67, 17);
            this.esrCheckBox.TabIndex = 30;
            this.esrCheckBox.Text = "Disabled";
            this.esrCheckBox.UseVisualStyleBackColor = true;
            this.esrCheckBox.Click += new System.EventHandler(this.esrCheckBox_Click);
            // 
            // enumServerNamesButton
            // 
            this.enumServerNamesButton.Location = new System.Drawing.Point(355, 48);
            this.enumServerNamesButton.Name = "enumServerNamesButton";
            this.enumServerNamesButton.Size = new System.Drawing.Size(75, 23);
            this.enumServerNamesButton.TabIndex = 13;
            this.enumServerNamesButton.Text = "EnumServerNames";
            this.enumServerNamesButton.UseVisualStyleBackColor = true;
            this.enumServerNamesButton.Click += new System.EventHandler(this.enumServerNamesButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ApiVer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "AppName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Server ID";
            // 
            // apiVer_textBox
            // 
            this.apiVer_textBox.Location = new System.Drawing.Point(130, 155);
            this.apiVer_textBox.Name = "apiVer_textBox";
            this.apiVer_textBox.Size = new System.Drawing.Size(300, 20);
            this.apiVer_textBox.TabIndex = 4;
            this.apiVer_textBox.Leave += new System.EventHandler(this.apiVer_textBox_Leave);
            // 
            // appName_textBox
            // 
            this.appName_textBox.Location = new System.Drawing.Point(130, 129);
            this.appName_textBox.Name = "appName_textBox";
            this.appName_textBox.Size = new System.Drawing.Size(300, 20);
            this.appName_textBox.TabIndex = 3;
            this.appName_textBox.Leave += new System.EventHandler(this.appName_textBox_Leave);
            // 
            // password_textBox
            // 
            this.password_textBox.Location = new System.Drawing.Point(130, 103);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(300, 20);
            this.password_textBox.TabIndex = 2;
            this.password_textBox.Leave += new System.EventHandler(this.password_textBox_Leave);
            // 
            // login_textBox
            // 
            this.login_textBox.Location = new System.Drawing.Point(130, 77);
            this.login_textBox.Name = "login_textBox";
            this.login_textBox.Size = new System.Drawing.Size(300, 20);
            this.login_textBox.TabIndex = 1;
            this.login_textBox.Leave += new System.EventHandler(this.login_textBox_Leave);
            // 
            // serverId_textBox
            // 
            this.serverId_textBox.Location = new System.Drawing.Point(130, 51);
            this.serverId_textBox.MaxLength = 64;
            this.serverId_textBox.Name = "serverId_textBox";
            this.serverId_textBox.Size = new System.Drawing.Size(219, 20);
            this.serverId_textBox.TabIndex = 0;
            this.serverId_textBox.Leave += new System.EventHandler(this.serverID_textBox_Leave);
            // 
            // TestsTab
            // 
            this.TestsTab.Controls.Add(this.groupBox4);
            this.TestsTab.Controls.Add(this.groupBox3);
            this.TestsTab.Controls.Add(this.groupBox2);
            this.TestsTab.Controls.Add(this.groupBox1);
            this.TestsTab.Controls.Add(this.label9);
            this.TestsTab.Controls.Add(this.logTextBox);
            this.TestsTab.Controls.Add(this.label7);
            this.TestsTab.Controls.Add(this.streamCheckbox);
            this.TestsTab.Location = new System.Drawing.Point(4, 22);
            this.TestsTab.Name = "TestsTab";
            this.TestsTab.Padding = new System.Windows.Forms.Padding(3);
            this.TestsTab.Size = new System.Drawing.Size(1119, 468);
            this.TestsTab.TabIndex = 0;
            this.TestsTab.Text = "Tests";
            this.TestsTab.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cstaSetMsgWaitingIndButton);
            this.groupBox4.Controls.Add(this.cstaSetForwardingButton);
            this.groupBox4.Controls.Add(this.cstaSetDoNotDisturbButton);
            this.groupBox4.Controls.Add(this.attSetBillRateButton);
            this.groupBox4.Controls.Add(this.cstaSetAgentStateButton);
            this.groupBox4.Controls.Add(this.attSetAdviceOfChargeButton);
            this.groupBox4.Location = new System.Drawing.Point(314, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(99, 200);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Set features";
            // 
            // cstaSetMsgWaitingIndButton
            // 
            this.cstaSetMsgWaitingIndButton.Location = new System.Drawing.Point(6, 164);
            this.cstaSetMsgWaitingIndButton.Name = "cstaSetMsgWaitingIndButton";
            this.cstaSetMsgWaitingIndButton.Size = new System.Drawing.Size(87, 23);
            this.cstaSetMsgWaitingIndButton.TabIndex = 5;
            this.cstaSetMsgWaitingIndButton.Text = "SetMsgWtInd";
            this.cstaSetMsgWaitingIndButton.UseVisualStyleBackColor = true;
            // 
            // cstaSetForwardingButton
            // 
            this.cstaSetForwardingButton.Location = new System.Drawing.Point(6, 135);
            this.cstaSetForwardingButton.Name = "cstaSetForwardingButton";
            this.cstaSetForwardingButton.Size = new System.Drawing.Size(87, 23);
            this.cstaSetForwardingButton.TabIndex = 4;
            this.cstaSetForwardingButton.Text = "SetForwarding";
            this.cstaSetForwardingButton.UseVisualStyleBackColor = true;
            // 
            // cstaSetDoNotDisturbButton
            // 
            this.cstaSetDoNotDisturbButton.Location = new System.Drawing.Point(6, 106);
            this.cstaSetDoNotDisturbButton.Name = "cstaSetDoNotDisturbButton";
            this.cstaSetDoNotDisturbButton.Size = new System.Drawing.Size(87, 23);
            this.cstaSetDoNotDisturbButton.TabIndex = 3;
            this.cstaSetDoNotDisturbButton.Text = "SetDND";
            this.cstaSetDoNotDisturbButton.UseVisualStyleBackColor = true;
            this.cstaSetDoNotDisturbButton.Click += new System.EventHandler(this.cstaSetDoNotDisturbButton_Click);
            // 
            // attSetBillRateButton
            // 
            this.attSetBillRateButton.Location = new System.Drawing.Point(6, 77);
            this.attSetBillRateButton.Name = "attSetBillRateButton";
            this.attSetBillRateButton.Size = new System.Drawing.Size(87, 23);
            this.attSetBillRateButton.TabIndex = 2;
            this.attSetBillRateButton.Text = "SetBillRate";
            this.attSetBillRateButton.UseVisualStyleBackColor = true;
            this.attSetBillRateButton.Click += new System.EventHandler(this.attSetBillRateButton_Click);
            // 
            // cstaSetAgentStateButton
            // 
            this.cstaSetAgentStateButton.Location = new System.Drawing.Point(6, 48);
            this.cstaSetAgentStateButton.Name = "cstaSetAgentStateButton";
            this.cstaSetAgentStateButton.Size = new System.Drawing.Size(87, 23);
            this.cstaSetAgentStateButton.TabIndex = 1;
            this.cstaSetAgentStateButton.Text = "SetAgentState";
            this.cstaSetAgentStateButton.UseVisualStyleBackColor = true;
            this.cstaSetAgentStateButton.Click += new System.EventHandler(this.cstaSetAgentStateButton_Click);
            // 
            // attSetAdviceOfChargeButton
            // 
            this.attSetAdviceOfChargeButton.Location = new System.Drawing.Point(6, 19);
            this.attSetAdviceOfChargeButton.Name = "attSetAdviceOfChargeButton";
            this.attSetAdviceOfChargeButton.Size = new System.Drawing.Size(87, 23);
            this.attSetAdviceOfChargeButton.TabIndex = 0;
            this.attSetAdviceOfChargeButton.Text = "SetAdviceOC";
            this.attSetAdviceOfChargeButton.UseVisualStyleBackColor = true;
            this.attSetAdviceOfChargeButton.Click += new System.EventHandler(this.attSetAdviceOfChargeButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cstaGetAPICapsButton);
            this.groupBox3.Controls.Add(this.cstaGetDeviceListButton);
            this.groupBox3.Controls.Add(this.cstaQueryCallMonitorButton);
            this.groupBox3.Location = new System.Drawing.Point(209, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 110);
            this.groupBox3.TabIndex = 42;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CSTA control";
            // 
            // cstaGetAPICapsButton
            // 
            this.cstaGetAPICapsButton.Location = new System.Drawing.Point(6, 19);
            this.cstaGetAPICapsButton.Name = "cstaGetAPICapsButton";
            this.cstaGetAPICapsButton.Size = new System.Drawing.Size(87, 23);
            this.cstaGetAPICapsButton.TabIndex = 14;
            this.cstaGetAPICapsButton.Text = "GetAPICaps";
            this.cstaGetAPICapsButton.UseVisualStyleBackColor = true;
            this.cstaGetAPICapsButton.Click += new System.EventHandler(this.cstaGetAPICapsButton_Click);
            // 
            // cstaGetDeviceListButton
            // 
            this.cstaGetDeviceListButton.Location = new System.Drawing.Point(6, 48);
            this.cstaGetDeviceListButton.Name = "cstaGetDeviceListButton";
            this.cstaGetDeviceListButton.Size = new System.Drawing.Size(87, 23);
            this.cstaGetDeviceListButton.TabIndex = 11;
            this.cstaGetDeviceListButton.Text = "GetDeviceList";
            this.cstaGetDeviceListButton.UseVisualStyleBackColor = true;
            this.cstaGetDeviceListButton.Click += new System.EventHandler(this.cstaGetDeviceListButton_Click);
            // 
            // cstaQueryCallMonitorButton
            // 
            this.cstaQueryCallMonitorButton.Location = new System.Drawing.Point(6, 77);
            this.cstaQueryCallMonitorButton.Name = "cstaQueryCallMonitorButton";
            this.cstaQueryCallMonitorButton.Size = new System.Drawing.Size(87, 23);
            this.cstaQueryCallMonitorButton.TabIndex = 15;
            this.cstaQueryCallMonitorButton.Text = "QueryCallMonitor";
            this.cstaQueryCallMonitorButton.UseVisualStyleBackColor = true;
            this.cstaQueryCallMonitorButton.Click += new System.EventHandler(this.cstaQueryCallMonitorButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.acsFlushEventQueueButton);
            this.groupBox2.Controls.Add(this.acsQueryAuthInfoButton);
            this.groupBox2.Controls.Add(this.acsSetHeartbeatIntervalButton);
            this.groupBox2.Location = new System.Drawing.Point(209, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 119);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acs Functions";
            // 
            // acsFlushEventQueueButton
            // 
            this.acsFlushEventQueueButton.Location = new System.Drawing.Point(6, 19);
            this.acsFlushEventQueueButton.Name = "acsFlushEventQueueButton";
            this.acsFlushEventQueueButton.Size = new System.Drawing.Size(87, 23);
            this.acsFlushEventQueueButton.TabIndex = 5;
            this.acsFlushEventQueueButton.Text = "FlushEventQueue";
            this.acsFlushEventQueueButton.UseVisualStyleBackColor = true;
            this.acsFlushEventQueueButton.Click += new System.EventHandler(this.flushEventQueueButton_Click);
            // 
            // acsQueryAuthInfoButton
            // 
            this.acsQueryAuthInfoButton.Location = new System.Drawing.Point(6, 48);
            this.acsQueryAuthInfoButton.Name = "acsQueryAuthInfoButton";
            this.acsQueryAuthInfoButton.Size = new System.Drawing.Size(87, 23);
            this.acsQueryAuthInfoButton.TabIndex = 12;
            this.acsQueryAuthInfoButton.Text = "QueryAuthInfo";
            this.acsQueryAuthInfoButton.UseVisualStyleBackColor = true;
            this.acsQueryAuthInfoButton.Click += new System.EventHandler(this.acsQueryAuthInfoButton_Click);
            // 
            // acsSetHeartbeatIntervalButton
            // 
            this.acsSetHeartbeatIntervalButton.Location = new System.Drawing.Point(6, 77);
            this.acsSetHeartbeatIntervalButton.Name = "acsSetHeartbeatIntervalButton";
            this.acsSetHeartbeatIntervalButton.Size = new System.Drawing.Size(87, 34);
            this.acsSetHeartbeatIntervalButton.TabIndex = 13;
            this.acsSetHeartbeatIntervalButton.Text = "Set Heartbeat Interval";
            this.acsSetHeartbeatIntervalButton.UseVisualStyleBackColor = true;
            this.acsSetHeartbeatIntervalButton.Click += new System.EventHandler(this.acsSetHeartbeatIntervalButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cstaClearConnectionButton);
            this.groupBox1.Controls.Add(this.cstaClearCallButton);
            this.groupBox1.Controls.Add(this.cstaTransferCallButton);
            this.groupBox1.Controls.Add(this.cstaAlternateCallButton);
            this.groupBox1.Controls.Add(this.attSingleStepTransferCallButton);
            this.groupBox1.Controls.Add(this.cstaAnswerCallButton);
            this.groupBox1.Controls.Add(this.attSingleStepConferenceCallButton);
            this.groupBox1.Controls.Add(this.cstaConferenceCallButton);
            this.groupBox1.Controls.Add(this.attSelectiveListeningRetrieveButton);
            this.groupBox1.Controls.Add(this.cstaConsultantCallButton);
            this.groupBox1.Controls.Add(this.attSelectiveListeningHoldButton);
            this.groupBox1.Controls.Add(this.deflectCallButton);
            this.groupBox1.Controls.Add(this.SendDTMFToneButton);
            this.groupBox1.Controls.Add(this.cstaHoldButton);
            this.groupBox1.Controls.Add(this.cstaRetrieveCallButton);
            this.groupBox1.Controls.Add(this.cstaMakeCallButton);
            this.groupBox1.Controls.Add(this.cstaMakePredictiveCallButton);
            this.groupBox1.Controls.Add(this.cstaPickupCallButton);
            this.groupBox1.Controls.Add(this.cstaReconnectCallButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 315);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CallControl";
            // 
            // cstaClearConnectionButton
            // 
            this.cstaClearConnectionButton.Location = new System.Drawing.Point(11, 107);
            this.cstaClearConnectionButton.Name = "cstaClearConnectionButton";
            this.cstaClearConnectionButton.Size = new System.Drawing.Size(87, 23);
            this.cstaClearConnectionButton.TabIndex = 41;
            this.cstaClearConnectionButton.Text = "ClearConn";
            this.cstaClearConnectionButton.UseVisualStyleBackColor = true;
            this.cstaClearConnectionButton.Click += new System.EventHandler(this.cstaClearConnectionButton_Click);
            // 
            // cstaClearCallButton
            // 
            this.cstaClearCallButton.Location = new System.Drawing.Point(11, 77);
            this.cstaClearCallButton.Name = "cstaClearCallButton";
            this.cstaClearCallButton.Size = new System.Drawing.Size(87, 23);
            this.cstaClearCallButton.TabIndex = 40;
            this.cstaClearCallButton.Text = "ClearCall";
            this.cstaClearCallButton.UseVisualStyleBackColor = true;
            this.cstaClearCallButton.Click += new System.EventHandler(this.cstaClearCallButton_Click);
            // 
            // cstaTransferCallButton
            // 
            this.cstaTransferCallButton.Location = new System.Drawing.Point(104, 252);
            this.cstaTransferCallButton.Name = "cstaTransferCallButton";
            this.cstaTransferCallButton.Size = new System.Drawing.Size(87, 23);
            this.cstaTransferCallButton.TabIndex = 39;
            this.cstaTransferCallButton.Text = "TransCall";
            this.cstaTransferCallButton.UseVisualStyleBackColor = true;
            this.cstaTransferCallButton.Click += new System.EventHandler(this.cstaTransferCallButton_Click);
            // 
            // cstaAlternateCallButton
            // 
            this.cstaAlternateCallButton.Location = new System.Drawing.Point(11, 20);
            this.cstaAlternateCallButton.Name = "cstaAlternateCallButton";
            this.cstaAlternateCallButton.Size = new System.Drawing.Size(87, 23);
            this.cstaAlternateCallButton.TabIndex = 16;
            this.cstaAlternateCallButton.Text = "AlternateCall";
            this.cstaAlternateCallButton.UseVisualStyleBackColor = true;
            this.cstaAlternateCallButton.Click += new System.EventHandler(this.cstaAlternateCallButton_Click);
            // 
            // attSingleStepTransferCallButton
            // 
            this.attSingleStepTransferCallButton.Location = new System.Drawing.Point(104, 223);
            this.attSingleStepTransferCallButton.Name = "attSingleStepTransferCallButton";
            this.attSingleStepTransferCallButton.Size = new System.Drawing.Size(87, 23);
            this.attSingleStepTransferCallButton.TabIndex = 38;
            this.attSingleStepTransferCallButton.Text = "SSTrans";
            this.attSingleStepTransferCallButton.UseVisualStyleBackColor = true;
            this.attSingleStepTransferCallButton.Click += new System.EventHandler(this.attSingleStepTransferCallButton_Click);
            // 
            // cstaAnswerCallButton
            // 
            this.cstaAnswerCallButton.Location = new System.Drawing.Point(11, 49);
            this.cstaAnswerCallButton.Name = "cstaAnswerCallButton";
            this.cstaAnswerCallButton.Size = new System.Drawing.Size(87, 23);
            this.cstaAnswerCallButton.TabIndex = 17;
            this.cstaAnswerCallButton.Text = "AnswerCall";
            this.cstaAnswerCallButton.UseVisualStyleBackColor = true;
            this.cstaAnswerCallButton.Click += new System.EventHandler(this.cstaAnswerCallButton_Click);
            // 
            // attSingleStepConferenceCallButton
            // 
            this.attSingleStepConferenceCallButton.Location = new System.Drawing.Point(104, 194);
            this.attSingleStepConferenceCallButton.Name = "attSingleStepConferenceCallButton";
            this.attSingleStepConferenceCallButton.Size = new System.Drawing.Size(87, 23);
            this.attSingleStepConferenceCallButton.TabIndex = 37;
            this.attSingleStepConferenceCallButton.Text = "SSConf";
            this.attSingleStepConferenceCallButton.UseVisualStyleBackColor = true;
            this.attSingleStepConferenceCallButton.Click += new System.EventHandler(this.attSingleStepConferenceCallButton_Click);
            // 
            // cstaConferenceCallButton
            // 
            this.cstaConferenceCallButton.Location = new System.Drawing.Point(11, 136);
            this.cstaConferenceCallButton.Name = "cstaConferenceCallButton";
            this.cstaConferenceCallButton.Size = new System.Drawing.Size(87, 23);
            this.cstaConferenceCallButton.TabIndex = 18;
            this.cstaConferenceCallButton.Text = "ConferenceCall";
            this.cstaConferenceCallButton.UseVisualStyleBackColor = true;
            this.cstaConferenceCallButton.Click += new System.EventHandler(this.cstaConferenceCallButton_Click);
            // 
            // attSelectiveListeningRetrieveButton
            // 
            this.attSelectiveListeningRetrieveButton.Location = new System.Drawing.Point(104, 165);
            this.attSelectiveListeningRetrieveButton.Name = "attSelectiveListeningRetrieveButton";
            this.attSelectiveListeningRetrieveButton.Size = new System.Drawing.Size(87, 23);
            this.attSelectiveListeningRetrieveButton.TabIndex = 36;
            this.attSelectiveListeningRetrieveButton.Text = "Sel.Retrieve";
            this.attSelectiveListeningRetrieveButton.UseVisualStyleBackColor = true;
            this.attSelectiveListeningRetrieveButton.Click += new System.EventHandler(this.attSelectiveListeningRetrieveButton_Click);
            // 
            // cstaConsultantCallButton
            // 
            this.cstaConsultantCallButton.Location = new System.Drawing.Point(11, 165);
            this.cstaConsultantCallButton.Name = "cstaConsultantCallButton";
            this.cstaConsultantCallButton.Size = new System.Drawing.Size(87, 23);
            this.cstaConsultantCallButton.TabIndex = 19;
            this.cstaConsultantCallButton.Text = "ConsultantCall";
            this.cstaConsultantCallButton.UseVisualStyleBackColor = true;
            this.cstaConsultantCallButton.Click += new System.EventHandler(this.cstaConsultantCallButton_Click);
            // 
            // attSelectiveListeningHoldButton
            // 
            this.attSelectiveListeningHoldButton.Location = new System.Drawing.Point(104, 136);
            this.attSelectiveListeningHoldButton.Name = "attSelectiveListeningHoldButton";
            this.attSelectiveListeningHoldButton.Size = new System.Drawing.Size(87, 23);
            this.attSelectiveListeningHoldButton.TabIndex = 35;
            this.attSelectiveListeningHoldButton.Text = "SelectHold";
            this.attSelectiveListeningHoldButton.UseVisualStyleBackColor = true;
            this.attSelectiveListeningHoldButton.Click += new System.EventHandler(this.attSelectiveListeningHoldButton_Click);
            // 
            // deflectCallButton
            // 
            this.deflectCallButton.Location = new System.Drawing.Point(11, 194);
            this.deflectCallButton.Name = "deflectCallButton";
            this.deflectCallButton.Size = new System.Drawing.Size(87, 23);
            this.deflectCallButton.TabIndex = 20;
            this.deflectCallButton.Text = "DeflectCall";
            this.deflectCallButton.UseVisualStyleBackColor = true;
            this.deflectCallButton.Click += new System.EventHandler(this.deflectCallButton_Click);
            // 
            // SendDTMFToneButton
            // 
            this.SendDTMFToneButton.Location = new System.Drawing.Point(104, 107);
            this.SendDTMFToneButton.Name = "SendDTMFToneButton";
            this.SendDTMFToneButton.Size = new System.Drawing.Size(87, 23);
            this.SendDTMFToneButton.TabIndex = 34;
            this.SendDTMFToneButton.Text = "SendDTMF";
            this.SendDTMFToneButton.UseVisualStyleBackColor = true;
            this.SendDTMFToneButton.Click += new System.EventHandler(this.SendDTMFToneButton_Click);
            // 
            // cstaHoldButton
            // 
            this.cstaHoldButton.Location = new System.Drawing.Point(11, 223);
            this.cstaHoldButton.Name = "cstaHoldButton";
            this.cstaHoldButton.Size = new System.Drawing.Size(87, 23);
            this.cstaHoldButton.TabIndex = 21;
            this.cstaHoldButton.Text = "HoldCall";
            this.cstaHoldButton.UseVisualStyleBackColor = true;
            this.cstaHoldButton.Click += new System.EventHandler(this.cstaHoldButton_Click);
            // 
            // cstaRetrieveCallButton
            // 
            this.cstaRetrieveCallButton.Location = new System.Drawing.Point(104, 78);
            this.cstaRetrieveCallButton.Name = "cstaRetrieveCallButton";
            this.cstaRetrieveCallButton.Size = new System.Drawing.Size(87, 23);
            this.cstaRetrieveCallButton.TabIndex = 33;
            this.cstaRetrieveCallButton.Text = "RetrieveCall";
            this.cstaRetrieveCallButton.UseVisualStyleBackColor = true;
            this.cstaRetrieveCallButton.Click += new System.EventHandler(this.cstaRetrieveCallButton_Click);
            // 
            // cstaMakeCallButton
            // 
            this.cstaMakeCallButton.Location = new System.Drawing.Point(11, 252);
            this.cstaMakeCallButton.Name = "cstaMakeCallButton";
            this.cstaMakeCallButton.Size = new System.Drawing.Size(87, 23);
            this.cstaMakeCallButton.TabIndex = 22;
            this.cstaMakeCallButton.Text = "MakeCall";
            this.cstaMakeCallButton.UseVisualStyleBackColor = true;
            this.cstaMakeCallButton.Click += new System.EventHandler(this.cstaMakeCallButton_Click);
            // 
            // cstaMakePredictiveCallButton
            // 
            this.cstaMakePredictiveCallButton.Location = new System.Drawing.Point(11, 281);
            this.cstaMakePredictiveCallButton.Name = "cstaMakePredictiveCallButton";
            this.cstaMakePredictiveCallButton.Size = new System.Drawing.Size(87, 23);
            this.cstaMakePredictiveCallButton.TabIndex = 23;
            this.cstaMakePredictiveCallButton.Text = "PredictiveCall";
            this.cstaMakePredictiveCallButton.UseVisualStyleBackColor = true;
            this.cstaMakePredictiveCallButton.Click += new System.EventHandler(this.cstaMakePredictiveCallButton_Click);
            // 
            // cstaPickupCallButton
            // 
            this.cstaPickupCallButton.Location = new System.Drawing.Point(104, 20);
            this.cstaPickupCallButton.Name = "cstaPickupCallButton";
            this.cstaPickupCallButton.Size = new System.Drawing.Size(87, 23);
            this.cstaPickupCallButton.TabIndex = 24;
            this.cstaPickupCallButton.Text = "PickupCall";
            this.cstaPickupCallButton.UseVisualStyleBackColor = true;
            this.cstaPickupCallButton.Click += new System.EventHandler(this.cstaPickupCallButton_Click);
            // 
            // cstaReconnectCallButton
            // 
            this.cstaReconnectCallButton.Location = new System.Drawing.Point(104, 49);
            this.cstaReconnectCallButton.Name = "cstaReconnectCallButton";
            this.cstaReconnectCallButton.Size = new System.Drawing.Size(87, 23);
            this.cstaReconnectCallButton.TabIndex = 25;
            this.cstaReconnectCallButton.Text = "Reconn.Call";
            this.cstaReconnectCallButton.UseVisualStyleBackColor = true;
            this.cstaReconnectCallButton.Click += new System.EventHandler(this.cstaReconnectCallButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Location = new System.Drawing.Point(583, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Log";
            // 
            // logTextBox
            // 
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.logTextBox.Location = new System.Drawing.Point(608, 3);
            this.logTextBox.MaxLength = 32000;
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(508, 462);
            this.logTextBox.TabIndex = 31;
            this.logTextBox.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "ACS stream status:";
            // 
            // streamCheckbox
            // 
            this.streamCheckbox.AutoSize = true;
            this.streamCheckbox.Location = new System.Drawing.Point(22, 448);
            this.streamCheckbox.Name = "streamCheckbox";
            this.streamCheckbox.Size = new System.Drawing.Size(95, 17);
            this.streamCheckbox.TabIndex = 9;
            this.streamCheckbox.Text = "not connected";
            this.streamCheckbox.UseVisualStyleBackColor = true;
            this.streamCheckbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.connectionCheckbox_MouseClick);
            // 
            // snapShotDeviceButton
            // 
            this.snapShotDeviceButton.Enabled = false;
            this.snapShotDeviceButton.Location = new System.Drawing.Point(209, 4);
            this.snapShotDeviceButton.Name = "snapShotDeviceButton";
            this.snapShotDeviceButton.Size = new System.Drawing.Size(98, 23);
            this.snapShotDeviceButton.TabIndex = 4;
            this.snapShotDeviceButton.Text = "SnapShotDevice";
            this.snapShotDeviceButton.UseVisualStyleBackColor = true;
            this.snapShotDeviceButton.Click += new System.EventHandler(this.snapShotDeviceButton_Click);
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.Location = new System.Drawing.Point(12, 12);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(55, 13);
            this.deviceLabel.TabIndex = 6;
            this.deviceLabel.Text = "Device ID";
            // 
            // deviceTextBox
            // 
            this.deviceTextBox.Location = new System.Drawing.Point(90, 7);
            this.deviceTextBox.MaxLength = 64;
            this.deviceTextBox.Name = "deviceTextBox";
            this.deviceTextBox.Size = new System.Drawing.Size(100, 20);
            this.deviceTextBox.TabIndex = 5;
            this.deviceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deviceTextBox_KeyPress);
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.TestsTab);
            this.mainTabs.Controls.Add(this.configTab);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainTabs.Location = new System.Drawing.Point(0, 40);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(1127, 494);
            this.mainTabs.TabIndex = 2;
            this.mainTabs.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.mainTabs_Selecting);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 534);
            this.Controls.Add(this.deviceLabel);
            this.Controls.Add(this.mainTabs);
            this.Controls.Add(this.deviceTextBox);
            this.Controls.Add(this.snapShotDeviceButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.Text = "TSAPI demo app";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.configTab.ResumeLayout(false);
            this.configTab.PerformLayout();
            this.TestsTab.ResumeLayout(false);
            this.TestsTab.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.mainTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage configTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apiVer_textBox;
        private System.Windows.Forms.TextBox appName_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.TextBox login_textBox;
        private System.Windows.Forms.TextBox serverId_textBox;
        private System.Windows.Forms.TabPage TestsTab;
        private System.Windows.Forms.CheckBox streamCheckbox;
        private System.Windows.Forms.Label deviceLabel;
        private System.Windows.Forms.TextBox deviceTextBox;
        private System.Windows.Forms.Button snapShotDeviceButton;
        private System.Windows.Forms.TabControl mainTabs;
        public bool configured = false;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cstaGetDeviceListButton;
        private System.Windows.Forms.Button acsFlushEventQueueButton;
        private System.Windows.Forms.Button enumServerNamesButton;
        private System.Windows.Forms.Button acsQueryAuthInfoButton;
        private System.Windows.Forms.Button acsSetHeartbeatIntervalButton;
        private System.Windows.Forms.Button cstaGetAPICapsButton;
        private System.Windows.Forms.Button cstaQueryCallMonitorButton;
        private System.Windows.Forms.Button cstaAlternateCallButton;
        private System.Windows.Forms.Button cstaAnswerCallButton;
        private System.Windows.Forms.Button cstaConferenceCallButton;
        private System.Windows.Forms.Button cstaConsultantCallButton;
        private System.Windows.Forms.Button deflectCallButton;
        private System.Windows.Forms.Button cstaHoldButton;
        private System.Windows.Forms.Button cstaMakeCallButton;
        private System.Windows.Forms.Button cstaMakePredictiveCallButton;
        private System.Windows.Forms.Button cstaPickupCallButton;
        private System.Windows.Forms.Button cstaReconnectCallButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cstaRetrieveCallButton;
        private System.Windows.Forms.Button SendDTMFToneButton;
        private System.Windows.Forms.Button attSelectiveListeningHoldButton;
        private System.Windows.Forms.Button attSelectiveListeningRetrieveButton;
        private System.Windows.Forms.Button attSingleStepConferenceCallButton;
        private System.Windows.Forms.Button attSingleStepTransferCallButton;
        private System.Windows.Forms.Button cstaTransferCallButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox wmEventNotifyCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox esrCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cstaClearCallButton;
        private System.Windows.Forms.Button cstaClearConnectionButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button cstaSetMsgWaitingIndButton;
        private System.Windows.Forms.Button cstaSetForwardingButton;
        private System.Windows.Forms.Button cstaSetDoNotDisturbButton;
        private System.Windows.Forms.Button attSetBillRateButton;
        private System.Windows.Forms.Button cstaSetAgentStateButton;
        private System.Windows.Forms.Button attSetAdviceOfChargeButton;



    }
}

