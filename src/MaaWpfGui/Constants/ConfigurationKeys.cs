// <copyright file="ConfigurationKeys.cs" company="MaaAssistantArknights">
// MaaWpfGui - A part of the MaaCoreArknights project
// Copyright (C) 2021 MistEO and Contributors
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License v3.0 only as published by
// the Free Software Foundation, either version 3 of the License, or
// any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY
// </copyright>

namespace MaaWpfGui.Constants
{
    /// <summary>
    /// MaaWpfGui configuration keys
    /// </summary>
    public static class ConfigurationKeys
    {
        public const string CurrentConfiguration = "Current";
        public const string DefaultConfiguration = "Default";
        public const string GlobalConfiguration = "Global";
        public const string ConfigurationMap = "Configurations";

        // ReSharper disable once UnusedMember.Global
        public const string ConfigurationData = "Data";

        // ReSharper disable once UnusedMember.Global
        public const string ConfigurationCron = "Cron";

        public const string Localization = "GUI.Localization"; // 迁移
        public const string OperNameLanguage = "GUI.OperNameLanguage";
        public const string UseTray = "GUI.UseTray";
        public const string MinimizeToTray = "GUI.MinimizeToTray"; // 迁移
        public const string HideCloseButton = "GUI.HideCloseButton"; // 迁移
        public const string WindowTitleScrollable = "GUI.WindowTitleScrollable";
        public const string UseLogItemDateFormat = "GUI.UseLogItemDateFormat"; // 迁移
        public const string LogItemDateFormat = "GUI.LogItemDateFormatString"; // 迁移
        public const string WindowPlacement = "GUI.Placement"; // 迁移
        public const string LoadWindowPlacement = "GUI.Placement.Load"; // 迁移
        public const string SaveWindowPlacement = "GUI.Placement.SaveOnClosing"; // 迁移
        public const string UseAlternateStage = "GUI.UseAlternateStage";
        public const string AllowUseStoneSave = "GUI.AllowUseStoneSave";
        public const string HideUnavailableStage = "GUI.HideUnavailableStage";
        public const string HideSeries = "GUI.HideSeries";
        public const string CustomStageCode = "GUI.CustomStageCode";
        public const string InverseClearMode = "GUI.InverseClearMode"; // 迁移
        public const string WindowTitlePrefix = "GUI.WindowTitlePrefix"; // 迁移
        public const string WindowTitleSelectShowList = "GUI.WindowTitleSelectShowList";
        public const string SoberLanguage = "GUI.SoberLanguage";
        public const string Cheers = "GUI.Cheers";
        public const string Hangover = "GUI.Hangover";
        public const string LastBuyWineTime = "GUI.LastBuyWineTime";
        public const string CustomCulture = "GUI.CustomCulture";

        public const string AddressHistory = "Connect.AddressHistory";
        public const string AutoDetect = "Connect.AutoDetect"; // 迁移
        public const string AlwaysAutoDetect = "Connect.AlwaysAutoDetect"; // 迁移
        public const string ConnectAddress = "Connect.Address"; // 迁移
        public const string AdbPath = "Connect.AdbPath"; // 迁移
        public const string ConnectConfig = "Connect.ConnectConfig";
        public const string MuMu12ExtrasEnabled = "Connect.MuMu12Extras.Enabled";
        public const string MuMu12EmulatorPath = "Connect.MuMu12EmulatorPath";
        public const string MuMu12Index = "Connect.MuMu12Index";
        public const string MuMu12Display = "Connect.MuMu12Display";
        public const string LdPlayerExtrasEnabled = "Connect.LdPlayerExtras.Enabled";
        public const string LdPlayerEmulatorPath = "Connect.LdPlayerEmulatorPath";
        public const string LdPlayerIndex = "Connect.LdPlayerIndex";
        public const string RetryOnAdbDisconnected = "Connect.RetryOnDisconnected"; // 迁移
        public const string AllowAdbRestart = "Connect.AllowADBRestart"; // 迁移
        public const string AllowAdbHardRestart = "Connect.AllowADBHardRestart"; // 迁移
        public const string AdbLiteEnabled = "Connect.AdbLiteEnabled"; // 迁移
        public const string KillAdbOnExit = "Connect.KillAdbOnExit"; // 迁移
        public const string TouchMode = "Connect.TouchMode";
        public const string AdbReplaced = "Connect.AdbReplaced"; // 弃用，不进新配置

        public const string ClientType = "Start.ClientType";
        public const string AccountName = "Start.AccountName"; // 迁移
        public const string RunDirectly = "Start.RunDirectly";
        public const string MinimizeDirectly = "Start.MinimizeDirectly";
        public const string StartEmulator = "Start.StartEmulator";
        public const string MinimizingStartup = "Start.MinimizingStartup";
        public const string EmulatorPath = "Start.EmulatorPath";
        public const string EmulatorAddCommand = "Start.EmulatorAddCommand";
        public const string EmulatorWaitSeconds = "Start.EmulatorWaitSeconds";
        public const string AutoRestartOnDrop = "Start.AutoRestartOnDrop";
        public const string StartsWithScript = "Start.StartsWithScript";
        public const string EndsWithScript = "Start.EndsWithScript";
        public const string CopilotWithScript = "Start.CopilotWithScript";
        public const string ManualStopWithScript = "Start.ManualStopWithScript";
        public const string BlockSleep = "Start.BlockSleep";
        public const string BlockSleepWithScreenOn = "Start.BlockSleepWithScreenOn";

        public const string ChooseLevel3 = "Recruit.ChooseLevel3";
        public const string ChooseLevel4 = "Recruit.ChooseLevel4";
        public const string ChooseLevel5 = "Recruit.ChooseLevel5";
        public const string ChooseLevel6 = "Recruit.ChooseLevel6";
        public const string AutoSetTime = "Recruit.AutoSetTime";
        public const string Level3UseShortTime = "Recruit.IsLevel3UseShortTime";
        public const string Level3UseShortTime2 = "Recruit.IsLevel3UseShortTime2";
        public const string RecruitmentShowPotential = "Recruit.ShowPotential";

        public const string DormThreshold = "Infrast.DormThreshold";
        public const string UsesOfDrones = "Infrast.UsesOfDrones";
        public const string ContinueTraining = "Infrast.ContinueTraining";
        public const string DefaultInfrast = "Infrast.DefaultInfrast";
        public const string IsCustomInfrastFileReadOnly = "Infrast.IsCustomInfrastFileReadOnly";
        public const string DormFilterNotStationedEnabled = "Infrast.DormFilterNotStationedEnabled";
        public const string DormTrustEnabled = "Infrast.DormTrustEnabled";
        public const string OriginiumShardAutoReplenishment = "Infrast.OriginiumShardAutoReplenishment";
        public const string CustomInfrastEnabled = "Infrast.CustomInfrastEnabled";
        public const string CustomInfrastFile = "Infrast.CustomInfrastFile";
        public const string CustomInfrastPlanIndex = "Infrast.CustomInfrastPlanIndex";
        public const string CustomInfrastPlanShowInFightSettings = "Infrast.CustomInfrastPlanShowInFightSettings";

        public const string UseRemainingSanityStage = "Fight.UseRemainingSanityStage";
        public const string UseExpiringMedicine = "Fight.UseExpiringMedicine";
        public const string RemainingSanityStage = "Fight.RemainingSanityStage";

        public const string RoguelikeTheme = "Roguelike.RoguelikeTheme"; // 迁移
        public const string RoguelikeMode = "Roguelike.Mode";
        public const string RoguelikeSquad = "Roguelike.Squad";
        public const string RoguelikeRoles = "Roguelike.Roles";
        public const string RoguelikeCoreChar = "Roguelike.CoreChar";
        public const string RoguelikeStartWithEliteTwo = "Roguelike.RoguelikeStartWithEliteTwo";
        public const string RoguelikeOnlyStartWithEliteTwo = "Roguelike.RoguelikeOnlyStartWithEliteTwo";
        public const string Roguelike3FirstFloorFoldartal = "Roguelike.Roguelike3FirstFloorFoldartal";
        public const string Roguelike3StartFloorFoldartal = "Roguelike.Roguelike3StartFloorFoldartal";
        public const string Roguelike3NewSquad2StartingFoldartal = "Roguelike.Roguelike3NewSquad2StartingFoldartal";
        public const string Roguelike3NewSquad2StartingFoldartals = "Roguelike.Roguelike3NewSquad2StartingFoldartals";
        public const string RoguelikeUseSupportUnit = "Roguelike.RoguelikeUseSupportUnit";
        public const string RoguelikeEnableNonfriendSupport = "Roguelike.RoguelikeEnableNonfriendSupport";
        public const string RoguelikeDelayAbortUntilCombatComplete = "Roguelike.RoguelikeDelayAbortUntilCombatComplete";
        public const string RoguelikeStartsCount = "Roguelike.StartsCount";
        public const string RoguelikeInvestmentEnabled = "Roguelike.InvestmentEnabled";
        public const string RoguelikeInvestmentEnterSecondFloor = "Roguelike.InvestmentEnterSecondFloor";
        public const string RoguelikeRefreshTraderWithDice = "Roguelike.RefreshTraderWithDice";
        public const string RoguelikeInvestsCount = "Roguelike.InvestsCount";
        public const string RoguelikeStopWhenInvestmentFull = "Roguelike.StopWhenInvestmentFull";
        public const string RoguelikeDeploymentWithPause = "Roguelike.DeploymentWithPause";
        public const string RoguelikeStopAtFinalBoss = "Roguelike.ExitAtFinalBoss";
        public const string ReclamationTheme = "Reclamation.Theme";
        public const string ReclamationMode = "Reclamation.Mode";
        public const string ReclamationToolToCraft = "Reclamation.ToolToCraft";
        public const string ReclamationIncrementMode = "Reclamation.ReclamationIncrementMode";
        public const string ReclamationMaxCraftCountPerRound = "Reclamation.ReclamationMaxCraftCountPerRound";

        public const string RecruitMaxTimes = "AutoRecruit.MaxTimes"; // 迁移
        public const string AutoRecruitFirstList = "AutoRecruit.AutoRecruitFirstList"; // 迁移
        public const string RefreshLevel3 = "AutoRecruit.RefreshLevel3"; // 迁移
        public const string ForceRefresh = "AutoRecruit.ForceRefresh"; // 迁移
        public const string SelectExtraTags = "AutoRecruit.SelectExtraTags"; // 迁移
        public const string IsLevel3UseShortTime = "AutoRecruit.IsLevel3UseShortTime"; // 迁移
        public const string IsLevel3UseShortTime2 = "AutoRecruit.IsLevel3UseShortTime2"; // 迁移
        public const string NotChooseLevel1 = "AutoRecruit.NotChooseLevel1"; // 迁移
        public const string RecruitChooseLevel3 = "AutoRecruit.ChooseLevel3"; // 迁移
        public const string RecruitChooseLevel4 = "AutoRecruit.ChooseLevel4"; // 迁移
        public const string RecruitChooseLevel5 = "AutoRecruit.ChooseLevel5"; // 迁移

        public const string LastCreditFightTaskTime = "Visit.LastCreditFightTaskTime"; // 迁移
        public const string CreditFightTaskEnabled = "Visit.CreditFightTaskEnabled"; // 迁移
        public const string CreditFightSelectFormation = "Visit.CreditFightSelectFormation"; // 迁移

        public const string LastCreditVisitFriendsTime = "Mall.LastCreditVisitFriendsTime"; // 迁移
        public const string CreditVisitOnceADay = "Mall.CreditVisitOnceADay"; // 迁移
        public const string CreditVisitFriendsEnabled = "Mall.CreditVisitFriendsEnabled"; // 迁移
        public const string CreditShopping = "Mall.CreditShopping"; // 迁移
        public const string CreditFirstListNew = "Mall.CreditFirstListNew"; // 迁移
        public const string CreditBlackListNew = "Mall.CreditBlackListNew"; // 迁移
        public const string CreditForceShoppingIfCreditFull = "Mall.CreditForceShoppingIfCreditFull"; // 迁移
        public const string CreditOnlyBuyDiscount = "Mall.CreditOnlyBuyDiscount"; // 迁移
        public const string CreditReserveMaxCredit = "Mall.CreidtReserveMaxCredit"; // 迁移

        public const string ReceiveAward = "Mission.ReceiveAward"; // 迁移
        public const string ReceiveMail = "Mission.ReceiveMail"; // 迁移
        public const string ReceiveFreeRecruit = "Mission.ReceiveFreeRecruit"; // 迁移
        public const string ReceiveOrundum = "Mission.ReceiveOrundum"; // 迁移
        public const string ReceiveMining = "Mission.ReceiveMining"; // 迁移
        public const string ReceiveSpecialAccess = "Mission.ReceiveSpecialAccess"; // 迁移
        public const string CopilotAddUserAdditional = "Copilot.AddUserAdditional";
        public const string CopilotUserAdditional = "Copilot.UserAdditional";
        public const string CopilotLoopTimes = "Copilot.LoopTimes";
        public const string CopilotTaskList = "Copilot.CopilotTaskList";
        public const string UpdateProxy = "VersionUpdate.Proxy"; // 不完全迁移
        public const string ProxyType = "VersionUpdate.ProxyType";
        public const string VersionType = "VersionUpdate.VersionType"; // 迁移
        public const string UpdateCheck = "VersionUpdate.UpdateCheck"; // 迁移
        public const string UpdateAutoCheck = "VersionUpdate.ScheduledUpdateCheck"; // 迁移
        public const string ResourceApi = "VersionUpdate.ResourceApi"; // 迁移
        public const string AllowNightlyUpdates = "VersionUpdate.AllowNightlyUpdates";
        public const string HasAcknowledgedNightlyWarning = "VersionUpdate.HasAcknowledgedNightlyWarning";

        // 这个已经废弃了，还要留着吗？
        // ReSharper disable once UnusedMember.Global
        public const string UseAria2 = "VersionUpdate.UseAria2"; // 不迁移

        public const string AutoDownloadUpdatePackage = "VersionUpdate.AutoDownloadUpdatePackage"; // 迁移
        public const string AutoInstallUpdatePackage = "VersionUpdate.AutoInstallUpdatePackage"; // 迁移

        public const string PenguinId = "Penguin.Id";
        public const string IsDrGrandet = "Penguin.IsDrGrandet";
        public const string EnablePenguin = "Penguin.EnablePenguin";

        public const string EnableYituliu = "Yituliu.EnableYituliu";

        public const string BluestacksConfigPath = "Bluestacks.Config.Path";
        public const string BluestacksConfigKeyword = "Bluestacks.Config.Keyword";
        public const string BluestacksConfigError = "Bluestacks.Config.Error";

        public const string PostActions = "MainFunction.PostActions";
        public const string MainFunctionInverseMode = "MainFunction.InverseMode"; // 迁移
        public const string Stage1 = "MainFunction.Stage1";
        public const string Stage2 = "MainFunction.Stage2";
        public const string Stage3 = "MainFunction.Stage3";
        public const string UseMedicine = "MainFunction.UseMedicine";
        public const string UseMedicineQuantity = "MainFunction.UseMedicine.Quantity";
        public const string UseStone = "MainFunction.UseStone";
        public const string UseStoneQuantity = "MainFunction.UseStone.Quantity";
        public const string TimesLimited = "MainFunction.TimesLimited";
        public const string TimesLimitedQuantity = "MainFunction.TimesLimited.Quantity";
        public const string SeriesQuantity = "MainFunction.Series.Quantity";
        public const string DropsEnable = "MainFunction.Drops.Enable";
        public const string DropsItemId = "MainFunction.Drops.ItemId";
        public const string DropsItemName = "MainFunction.Drops.ItemName";
        public const string DropsQuantity = "MainFunction.Drops.Quantity";

        public const string RemoteControlGetTaskEndpointUri = "RemoteControl.RemoteControlGetTaskEndpointUri";
        public const string RemoteControlReportStatusUri = "RemoteControl.RemoteControlReportStatusUri";
        public const string RemoteControlUserIdentity = "RemoteControl.RemoteControlUserIdentity";
        public const string RemoteControlDeviceIdentity = "RemoteControl.RemoteControlDeviceIdentity";

        public const string ExternalNotificationEnabled = "ExternalNotification.Enabled";
        public const string ExternalNotificationSmtpServer = "ExternalNotification.Smtp.Server";
        public const string ExternalNotificationSmtpPort = "ExternalNotification.Smtp.Port";
        public const string ExternalNotificationSmtpUser = "ExternalNotification.Smtp.User";
        public const string ExternalNotificationSmtpPassword = "ExternalNotification.Smtp.Password";
        public const string ExternalNotificationSmtpUseSsl = "ExternalNotification.Smtp.UseSsl";
        public const string ExternalNotificationSmtpRequiresAuthentication = "ExternalNotification.Smtp.RequiresAuthentication";
        public const string ExternalNotificationSmtpFrom = "ExternalNotification.Smtp.From";
        public const string ExternalNotificationSmtpTo = "ExternalNotification.Smtp.To";
        public const string ExternalNotificationServerChanSendKey = "ExternalNotification.ServerChan.SendKey";
        public const string ExternalNotificationDiscordBotToken = "ExternalNotification.Discord.BotToken";
        public const string ExternalNotificationDiscordUserId = "ExternalNotification.Discord.UserId";
        public const string ExternalNotificationTelegramBotToken = "ExternalNotification.Telegram.BotToken";
        public const string ExternalNotificationTelegramChatId = "ExternalNotification.Telegram.ChatId";
        public const string ExternalNotificationBarkSendKey = "ExternalNotification.Bark.SendKey";
        public const string ExternalNotificationBarkServer = "ExternalNotification.Bark.Server";
        public const string ExternalNotificationQmsgServer = "ExternalNotification.Qmsg.Server";
        public const string ExternalNotificationQmsgKey = "ExternalNotification.Qmsg.Key";
        public const string ExternalNotificationQmsgUser = "ExternalNotification.Qmsg.User";
        public const string ExternalNotificationQmsgBot = "ExternalNotification.Qmsg.Bot";

        public const string PerformanceUseGpu = "Performance.UseGpu";
        public const string PerformancePreferredGpuDescription = "Performance.PreferredGpuDescription";
        public const string PerformancePreferredGpuInstancePath = "Performance.PreferredGpuInstancePath";
        public const string PerformanceAllowDeprecatedGpu = "Performance.AllowDeprecatedGpu";

        // The following should not be modified manually
        public const string VersionName = "VersionUpdate.name"; // 迁移

        public const string VersionUpdateBody = "VersionUpdate.body"; // 迁移
        public const string VersionUpdateIsFirstBoot = "VersionUpdate.isfirstboot"; // 迁移
        public const string VersionUpdatePackage = "VersionUpdate.package"; // 迁移
        public const string VersionUpdateDoNotShowUpdate = "VersionUpdate.doNotShowUpdate";

        public const string OperBoxData = "OperBox.Data";

        public const string GachaShowDisclaimerNoMore = "Gacha.ShowDisclaimerNoMore";

        public const string PeepTargetFps = "Peep.TargetFps";

        public const string GuideStepIndex = "Guide.StepIndex";

        public const string ForceScheduledStart = "Timer.ForceScheduledStart";
        public const string ShowWindowBeforeForceScheduledStart = "Timer.ShowWindowBeforeForceScheduledStart";
        public const string CustomConfig = "Timer.CustomConfig";

        // public const string AnnouncementInfo = "Announcement.AnnouncementInfo";// 已迁移
        // public const string DoNotRemindThisAnnouncementAgain = "Announcement.DoNotRemindThisAnnouncementAgain";// 已迁移
        // public const string DoNotShowAnnouncement = "Announcement.DoNotShowAnnouncement";// 已迁移
    }
}
