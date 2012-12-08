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

                                                                                                                                                                                                                                                                                                                                                                                                                                                                       ��?�p3�	!V2�0hb X@�W�Q���� ��9+b8d &WP�p�|3V	�B�PG�~H4��O12�K.��@����4#CXHAx��~�����z��`�1�T���^d�@�>=p�@�-!��h0���v�N:�͂��"w��De��9�"Q������.�^�ϘH 
�Hz������ ���� :���9��RP��r�y*,s���Yd���@XF������@�8���0��A�0̶Rx��@{����"jG��^1z��*�H?���bD�#�0A �D �I/��0S^�8tM��Z��16�@������&�I�W<���r ��E��<A v����J�T��9ʞ���	�y��P�@=��F�;Ϟ��5_�������X��^E 
�����˟3�O��!�O!�A��)[��ǥǪ,QX�Da��E�;9���P���AIF��4�A~������?:1�!�z5�z��TR;.Z����b$�Hy�Cf$W�	ѹar�a�W����F��#�	�"��z��0V��ah�	�-������?����(�	���@6��j�C��3,�D��@����o��]��[Jr��+ҕN ������e�D��B��g��"X'ԧ��d�aH�2��/뇝c�)��Wd�0�����
���6��^��@�7�%�~ �����(`��|C�}�c�"��zB��i��opD*�
������%��L�#P�0za��t<&�LH�C���r1�(Y����/T`�w�T��/o@	�C� ȃ�ή��"�� ��0�Qp��0=
����,� ���Ņ��kċ��Jq�A�rn ��0�g|a�	�@�P{�w�pH��0�0m����%q�����ǂ%�28u�`~7X� ;                          GIF89a� � �� �����������ʖ��BCC�����vwxP�����+���-MRhr��0FOo��UVVfhh���.n�vO��#1Mt�Kmtz�*��u�-��m��,Ql	k�
�����	�˚��0m/�111���OYfz���)6Gp��))),����M
M�itw��P��999���'�����L����-r�I��.�ʈ�����)R�CVp��o��/dy !!N��Hy�nO�����
P�hkt���m��������'14y�zHSU���   ���V��g���!(���*�������s����')2�������Xe���v�����EIU9B?0�����)Q��������ƽazz��!4��d��!7h������nKP��T2>���������3-���J�ⅷƆ�z��ެ��JKJdVg0�����_����Φ����ﳽ�ukv����w����6B099)1)������ftj��� ))���d��  ������Ycbsuk119��� C^���������������  ������VFG��絵�"!!*daZ���4'4191THTSSJc��j��11) ��&��CB9���j��ƽ�tik4'(����ƽýɥ�����K��!)!���991���������p�ή�E��ｵ�R��������{��))!�����筭�</02��>\����  H��2Y^������������:0: +  ���) )   !� � ,) A v Q  � �	H��������\@$�H��ŋ3"�pp�?WC�I�"��C"��T�b('���i���[$��(b`��<x�R�����Q��r=䜠Iu��+��!bS@���Q8$�*eZAȤ���V	�k��v�˻I�+N�̩ �È#f��B�ps5v�_��
������ Ø��ٳǄL��E>��_m�_'�k�%���6}�8<VisualStudioProject>
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

                                                                                                                                                                                                              �Z�Ƌ�"��@�BG�"	/`�:Q|��@ �����ᆑ������ĩ�wD���$+��r�H�����@Z�x�e�0�GI �3�K!$��t=`1���K&S(�/@{������@�}+Ȃj"�!a�0!4��<؃>m�o ;          