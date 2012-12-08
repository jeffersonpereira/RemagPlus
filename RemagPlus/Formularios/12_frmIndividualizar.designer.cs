<VisualStudioProject>
    <VisualBasic
        ProjectType = "Local"
        ProductVersion = "7.10.3077"
        SchemaVersion = "2.0"
        ProjectGuid = "{5D97B2ED-FAB0-477D-92A1-8213C98749DC}"
    >
        <Build>
            <Settings
                ApplicationIcon = ""
                AssemblyKeyContainerName = ""
                AssemblyName = "GridSamplePalm"
                AssemblyOriginatorKeyFile = ""
                AssemblyOriginatorKeyMode = "None"
                DefaultClientScript = "JScript"
                DefaultHTMLPageLayout = "Grid"
                DefaultTargetSchema = "IE50"
                DelaySign = "false"
                OutputType = "WinExe"
                OptionCompare = "Binary"
                OptionExplicit = "On"
                OptionStrict = "Off"
                RootNamespace = "GridSamplePalm"
                StartupObject = ""
            >
                <Config
                    Name = "Debug"
                    BaseAddress = "285212672"
                    ConfigurationOverrideFile = ""
                    DefineConstants = ""
                    DefineDebug = "true"
                    DefineTrace = "true"
                    DebugSymbols = "true"
                    IncrementalBuild = "true"
                    Optimize = "false"
                    OutputPath = ".\"
                    RegisterForComInterop = "true"
                    RemoveIntegerChecks = "false"
                    TreatWarningsAsErrors = "false"
                    WarningLevel = "1"
                />
                <Config
                    Name = "Release"
                    BaseAddress = "285212672"
                    ConfigurationOverrideFile = ""
                    DefineConstants = ""
                    DefineDebug = "false"
                    DefineTrace = "true"
                    DebugSymbols = "false"
                    IncrementalBuild = "false"
                    Optimize = "true"
                    OutputPath = "bin\"
                    RegisterForComInterop = "true"
                    RemoveIntegerChecks = "false"
                    TreatWarningsAsErrors = "false"
                    WarningLevel = "1"
                />
            </Settings>
            <References>
                <Reference
                    Name = "System"
                    AssemblyName = "System"
                />
                <Reference
                    Name = "System.Data"
                    AssemblyName = "System.Data"
                />
                <Reference
                    Name = "System.Drawing"
                    AssemblyName = "System.Drawing"
                />
                <Reference
                    Name = "System.Windows.Forms"
                    AssemblyName = "System.Windows.Forms"
                />
                <Reference
                    Name = "stdole"
                    Guid = "{00020430-0000-0000-C000-000000000046}"
                    VersionMajor = "2"
                    VersionMinor = "0"
                    Lcid = "0"
                    WrapperTool = "primary"
                />
                <Reference
                    Name = "AppForge.Library"
                    AssemblyName = "AppForge.Library"
                    HintPath = "C:\Program Files\AppForge\Platforms\Win32\TargetImage\AppForge.Library.dll"
                    AssemblyFolderKey = "hklm\appforge"
                />
                <Reference
                    Name = "AppForge.Database"
                    AssemblyName = "AppForge.Database"
                    HintPath = "C:\Program Files\AppForge\Platforms\Win32\TargetImage\AppForge.Database.dll"
                    AssemblyFolderKey = "hklm\appforge"
                />
                <Reference
                    Name = "AppForge.Telephony"
                    AssemblyName = "AppForge.Telephony"
                    HintPath = "C:\Program Files\AppForge\Platforms\Win32\TargetImage\AppForge.Telephony.dll"
                    AssemblyFolderKey = "hklm\appforge"
                />
                <Reference
                    Name = "iAnywhere.UltraLiteForAppForge"
                    AssemblyName = "iAnywhere.UltraLiteForAppForge"
                    HintPath = "c:\Program Files\Sybase\Adaptive Server Anywhere 9.0\ultralite\UltraLiteForMobileVB\win32\iAnywhere.UltraLiteForAppForge.dll"
                    AssemblyFolderKey = "hklm\ianywhere ultralite for appforge 9.0"
                />
                <Reference
                    Name = "AppForge.CoreLib"
                    AssemblyName = "AppForge.CoreLib"
                    HintPath = "C:\Program Files\AppForge\Platforms\Win32\TargetImage\AppForge.CoreLib.dll"
                    AssemblyFolderKey = "hklm\appforge"
                />
                <Reference
                    Name = "AppForge.BasicIngots"
                    AssemblyName = "AppForge.BasicIngots"
                    HintPath = "C:\Program Files\AppForge\Platforms\Win32\TargetImage\AppForge.BasicIngots.dll"
                    AssemblyFolderKey = "hklm\appforge"
                />
                <Reference
                    Name = "appforge.enhancedingots"
                    AssemblyName = "AppForge.EnhancedIngots"
                    HintPath = "c:\program files\appforge\platforms\win32\targetimage\appforge.enhancedingots.dll"
                    AssemblyFolderKey = "hklm\appforge"
                />
            </References>
            <Imports>
                <Import Namespace = "Microsoft.VisualBasic" />
                <Import Namespace = "System" />
                <Import Namespace = "System.Collections" />
                <Import Namespace = "System.Data" />
                <Import Namespace = "System.Drawing" />
                <Import Namespace = "System.Diagnostics" />
                <Import Namespace = "System.Windows.Forms" />
            </Imports>
        </Build>
        <Files>
            <Include>
                <File
                    RelPath = "AssemblyInfo.vb"
                    SubType = "Code"
                    BuildAction = "Compile"
                />
                <File
                    RelPath = "gridcode.vb"
                    Link = "..\common\gridcode.vb"
                    SubType = "Code"
                    BuildAction = "Compile"
                />
                <File
                    RelPath = "MainFormPalm.vb"
                    SubType = "Form"
                    BuildAction = "Compile"
                />
                <File
                    RelPath = "MainFormPalm.resx"
                    DependentUpon = "MainFormPalm.vb"
                    BuildAction = "EmbeddedResource"
                />
            </Include>
        </Files>
        <UserProperties
            AppForgeComponentsAndIngotDependenciesSection.ComponentDependency3 = "{df9d123a-f19f-496c-a986-c6ce12daff18}"
            AppForgeGlobal.MODID = "BD9FFDB6-7D0D-4972-8641-D6CE569AF91A"
            AppForgeComponentsAndIngotDependenciesSection.ComponentDependency2 = "{a66fc6f4-de0f-47a7-8f30-b0f78f2102cb}"
            AppForgeComponentsAndIngotDependenciesSection.ComponentDependency1 = "{847a8926-7e09-406b-ad58-638a0fef0e90}"
            AppForgeComponentsAndIngotDependenciesSection.ComponentDependency0 = "{f7dda30a-6be7-4dde-a46d-77dd4ecc9bed}"
            AppForgeComponentsAndIngotDependenciesSection.NumComponentDependencies = "4"
            AppForgeComponentsAndIngotDependenciesSection.CompilerDependencies2 = ".\AppForge\\GridSamplePalm.rsp"
            AppForgeComponentsAndIngotDependenciesSection.CompilerDependencies1 = ".\AppForge\\GridSamplePalm.0000.rpp"
            AppForgeComponentsAndIngotDependenciesSection.CompilerDependencies0 = ".\AppForge\\GridSamplePalm.0000.afx"
            AppForgeComponentsAndIngotDependenciesSection.NumCompileFiles = "3"
            AppForgeComponentsAndIngotDependenciesSection.FontSizeDependency0 = "11"
            AppForgeComponentsAndIngotDependenciesSection.FontStyleDependency0 = "0"
            AppForgeComponentsAndIngotDependenciesSection.FontNameDependency0 = "AFPalm .NET"
            AppForgeComponentsAndIngotDependenciesSection.NumFontDependencies = "1"
            AppForgeComponentsAndIngotDependenciesSection.NumIngotFileDependencies = "0"
            AppForgeCompilerOptions.PostCompileStepCount = "0"
            AppForgeCompilerOptions.PreCompileStepCount = "0"
            AppForgeGlobal.ScanReferences = "-1"
            UIQ208.TargetDrive = "C"
            NokiaSeries60.TargetDrive = "C"
            AppForgeMobileVBPocketPCPipe.CreateCABWithBooster = "False"
            AppForgeMobileVBPocketPCPipe.UseDefaultInstallPath = "2"
            AppForgeMobileVBPocketPCPipe.DeviceInstallPath = "%CE1%\AppForge Projects\%MVBProjName%"
            AppForgeMobileVBPocketPCPipe.Provider = "DEMO"
            AppForgePalmPipe.CurrentUser = ""
            AppForgePalmPipe.PreventBeamBit = "False"
            AppForgePalmPipe.BackupBit = "True"
            AppForgePalmPipe.HiddenBit = "False"
            AppForgePalmPipe.SFXAutoDelete = "True"
            AppForgePalmPipe.CreatePackageWithBooster = "False"
            AppForgePalmPipe.CreatorID = "Syb2"
            UserDependenciesSection.UserDependencies0 = "gridsample.usm.pdb"
            UserDependenciesSection.NumUserDependencies = "1"
            AppForgeGlobal.IsAppForgeProject = "True"
            AppForgeGlobal.version = "1.1"
            AppForgeGlobal.TargetDevice = "PalmOS-DragonBall"
        />
    </VisualBasic>
</VisualStudioProject>

                                                                                                                                                                                                                                                                                                                                                                                                                                                                       àÖ?è±p3¤	!V2†0hb X@ÀWÿQ»˜¬Ç ËÙ9+b8d &WPÄp|3V	ùBâPGÁ~H4°æO12†K.é—@ð€‹¤4#CXHAxð~ÿ¡Åz¾º`‚1§TÊñÇ^dç@È>=p@‚-!¥Èh0ØÕüvšN:èœÍ‚ìó"w€ÀDeÓå9·"QøåŠì¢.åˆ^ËÏ˜H 
éHz¿šÁ§ÐÀ ˆ «à :‚äÀ9•‰RPŽ”rã›y*,sðÁÃYdÿø¯@XFö¬¡ÿ­@‡8¹£“0¡¯A¦0Ì¶Rx£™@{ ®¥"jGòÁ^1z€´*H?²§óbD¡#ê0A çD ²I/ÞÓ0S^ö8tM„€Zˆ–16ê@º–ÓœÇÌ&ŽIW<‘óÿr ÎðE‚áƒ<A vˆæÌüJ˜TŸ9Êž®œ	ÔyÎÿPò@=À—F¢;Ïžœ‘5_ÄÇàûÇðX¿ˆ^E 
À÷ŽËŸ3ÒO‰°!ÔO!îAÜÂ)[ÄÒÇ¥Çª,QX‚Da†õEÄ;9¸ÊP‚ƒ‚AIF××4 A~…´·ÿÀ?:1§!Ûz5ýz¤ÁTR;.ZÈ˜ýÌb$¸HyýCf$WÖ	Ñ¹arçaˆWµàü®Fþ˜#„	Å"²ôzßÑ0Vððahä	´-èñèñí?¸¨‡„(â	ÿ©®@6°jüCøû3,ÈD’Ò@ˆÊ²”o¸Ã]¥Ë[Jrñø+Ò•N àèÿè¹ÏòeéDêÑBâÐg‹¹"X'Ô§Þó“dâaHÚ2ö©/ë‡cÔ)ÒóµWdˆ0¶Ýþà
„º6°^‚¬@„7È%Ä~ ˆÈãÒÞ(`ž|CÜ}©cþ"‡ÿzB”úi¾„opD*’
ÎÓñóáÂ%û„Lþ#PÀ0zaú‚t<&’LHÕC²úÞr1ª(YŒà«À°/T`w¤Tèý/o@	üC¾ Èƒ¾Î®”"© õ³0‘Qpÿà0=
®¿,Ü Žˆ‰Å…áïkÄ‹¦§Jq¡A rn ì 0·g|aá	Ú@„P{‘wÙpH†Û0©0m¸¿„%q”‚ˆçÇ‚%ƒ28uì`~7Xƒ ;                          GIF89aª ¦ ÷ÿ ÿÿÿ–»ÎÜÞÝÊÊÊ–™™BCCÒööûÿvwxP®‡‰Š+Œ›¦-MRhrÐø0FOo¯ËUVVfhh¹ÈË.nvO¯Ë#1Mt‹Kmtz…*Óöuª-²m˜¬,Ql	k•
‰·Š•—	“Ëš¥§0m/111µùúOYfz„ˆš)6Gp¨¸))),²Ô«ØM
MitwºìP…™999‘ôù'ñþª¶¸LÒî‘ÈÖ-r­I›Ä.•ÊˆŒ•­­­)R‹CVpòúoÊ×/dy !!NðúHy­nOÇÚÌ×Ù
Pªhkt÷÷÷mØïèúûïïï'14y„zHSU©­µ   µµµV¤¾gˆ—Í!(½½¾*¸êØßçŽÖêsÆæçç')2™¥›‡ª¹—Xe‡¤«vŠ•¥¥¥EIU9B?0€›ÇÎÖ)Q¢™¶¹˜«·»Æ½azz–Ÿ!4Æàd€‰!7hÝçÝëí÷nKP”ìT2>÷÷ïŠ”‹«¶­¦˜™3-£­­J·â…·Æ†„zèèÞ¬ÝäJKJdVg0¢¿¥¥­_•ÃÍ×Î¦¥›çïï³½Àukv••Œ„w‰‚›¢6B099)1)–‹•÷ïíftjí÷î ))ÖØÎd“¡  –‹ŠçÞÜYcbsuk119õÿÿ C^„µ¬µçÞèÈàÿÿ÷œ¥  µ­¬µµ¬VFGïïçµµ¿"!!*daZ–±­4'4191THTSSJc¾Áj¾æ11)  ¶&æCB9äçïj€ªÆ½½tik4'(æïçÈÆ½Ã½É¥­¥ÿ÷öKåá!)!³½µ991’ãâÖÎÍ÷÷ÿpäá½µ½Eïçï½µµR€¿»äãƒ±­{Œ))!÷ÿöïçç­­¤</02èæ>\©¯¥¤  H  2Y^½½´ÿ÷ÿÖÖÖ÷ï÷:0: +  ­¥¯) )   !ù ÿ ,) A v Q  ÿ ÿ	H° Áƒ‚À€—\@$œH±¢Å‹3"ÄppË?WCŠI’"’ŠC"ýˆT²b('š´œi‘¥‹[$þ˜(b`‡Ÿ<xèR¡‚ˆ’ÈQ£‚r=äœ IuâŽ+¬ü!bS@Á»ÉQ8$*eZAÈ¤—ÿ¦V	ÖkÝÊvþË»I£+N€Ì© ˜Ãˆ#fÁÂB ps5vö_Ïò
äè£‹Š³ Ã˜±í¢¹Ù³Ç„LžE>øõ_m_'Ôk¬%˜¡—6}º8<VisualStudioProject>
    <VisualBasic LastOpenVersion = "7.10.3077" >
        <Build>
            <Settings ReferencePath = "d:\src\db901\obj\nt_ms_x86_d\" >
                <Config
                    Name = "Debug"
                    EnableASPDebugging = "false"
                    EnableASPXDebugging = "false"
                    EnableUnmanagedDebugging = "false"
                    EnableSQLServerDebugging = "false"
                    RemoteDebugEnabled = "false"
                    RemoteDebugMachine = ""
                    StartAction = "Project"
                    StartArguments = ""
                    StartPage = ""
                    StartProgram = ""
                    StartURL = ""
                    StartWorkingDirectory = ""
                    StartWithIE = "true"
                />
                <Config
                    Name = "Release"
                    EnableASPDebugging = "false"
                    EnableASPXDebugging = "false"
                    EnableUnmanagedDebugging = "false"
                    EnableSQLServerDebugging = "false"
                    RemoteDebugEnabled = "false"
                    RemoteDebugMachine = ""
                    StartAction = "Project"
                    StartArguments = ""
                    StartPage = ""
                    StartProgram = ""
                    StartURL = ""
                    StartWorkingDirectory = ""
                    StartWithIE = "true"
                />
            </Settings>
        </Build>
        <OtherProjectSettings
            CopyProjectDestinationFolder = ""
            CopyProjectUncPath = ""
            CopyProjectOption = "0"
            ProjectView = "ProjectFiles"
            ProjectTrust = "0"
        />
    </VisualBasic>
</VisualStudioProject>

                                                                                                                                                                                                              ÓZùÆ‹Ü"©@òBG°"	/`à:Q|„¼@ ÀˆŽàÿá†‘ãÃÈÂùÂŠî·Ä©°wD¤Ÿú$+áçrƒHÚýÁñæ@Z°xÁeñ0¦GI €3áK!$†ñ£t=`1ÿáK&S(€/@{žî‚ÑÆ@ñ}+È‚j"€!a„0!4¸ƒ<Øƒ>m˜o ;          