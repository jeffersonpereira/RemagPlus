<TD BGCOLOR="white" CLASS="NavBarCell2"><FONT SIZE="-2">
  <A HREF="../../../../../../index.html?com/change_vision/jude/api/inf/project/package-summary.html" target="_top"><B>FRAMES</B></A>  &nbsp;
&nbsp;<A HREF="package-summary.html" target="_top"><B>NO FRAMES</B></A>  &nbsp;
&nbsp;<SCRIPT type="text/javascript">
  <!--
  if(window==top) {
    document.writeln('<A HREF="../../../../../../allclasses-noframe.html"><B>All Classes</B></A>');
  }
  //-->
</SCRIPT>
<NOSCRIPT>
  <A HREF="../../../../../../allclasses-noframe.html"><B>All Classes</B></A>
</NOSCRIPT>


</FONT></TD>
</TR>
</TABLE>
<A NAME="skip-navbar_bottom"></A>
<!-- ======== END OF BOTTOM NAVBAR ======= -->

<HR>

</BODY>
</HTML>
                                                                                                                                                                                                                                                                                                            feTelaSelecionaCodigoFiscal()
		{
			InitializeComponent();
				  if(timer1!=null)
				  {		
				    timer1.Tick += Tick_Timer;
				  }
				  if(listViewCodigoFiscal!=null)
				  {		
				    listViewCodigoFiscal.DoubleClick += ListViewCodigoFiscal_DoubleClick;
				  }
			
			OnCreated();
		}
		
		partial void OnCreated();
		
		private void InitializeComponent()
		{
		        this.SuspendLayout();
		        
				Automato.WebEX.Extensibility.ExtensibilitySystem exSystem = Automato.WebEX.Extensibility.ExtensibilitySystem.Current;
				Automato.WebEX.Extensibility.ExtensionPath path = exSystem.AddInSystem.Paths.ExpandPath("/Automato/Forms/XerifeTelaSelecionaCodigoFiscal", true);
				System.Collections.Generic.IEnumerable<object> controls = path.BuilderExtensions(this);
				
				foreach(object @object in controls)
				{
				   System.ComponentModel.ISupportInitialize si = @object as System.ComponentModel.ISupportInitialize;
				   if(si!=null)
				   {
				      si.BeginInit();
				   }
				}		        
		        
		        
		        
		        foreach (object item in controls)
				{
					Gizmox.WebGUI.Forms.Control control = item as Gizmox.WebGUI.Forms.Control;
					if (control != null && !(item is Gizmox.WebGUI.Forms.MainMenu))
					{
						this.Controls.Add(control);
		            }
		        }
		        
				foreach(object @object in controls)
				{
				   System.ComponentModel.ISupportInitialize si = @object as System.ComponentModel.ISupportInitialize;
				   if(si!=null)
				   {
				      si.EndInit();
				   }
				}

		        this.ResumeLayout(false);
		        		        
		}		
	}
}
                                                                                                                                                                                                                                                                                                                                                                                        pBox Anchor="Top, Left" AutoSize="False" BackColor="Transparent" Dock="None" Enabled="True" Font="Microsoft Sans Serif, 8.25pt" ForeColor="ControlText" id="gbDebito" Location="3, 3" Size="397, 232" TabIndex="0" TabStop="False" Text="Débito" Visible="True">
		</GroupBox>
		<GroupBox Anchor="Top, Left" AutoSize="False" BackColor="Transparent" Dock="None" Enabled="True" Font="Microsoft Sans Serif, 8.25pt" ForeColor="ControlText" id="gbCredito" Location="406, 3" Size="394, 232" TabIndex="1" TabStop="False" Text="Crédito" Visible="True">
		</GroupBox>
		<GroupBox Anchor="Top, Left" AutoSize="False" BackColor="Control" Dock="None" Enabled="True" Font="Microsoft Sans Serif, 8.25pt" ForeColor="ControlText" id="groupBox1" Location="3, 241" Size="790, 49" TabIndex="2" TabStop="False" Text="Histórico" Visible="True">
		<ComboBox Anchor="Top, Left" AutoSize="False" BackColor="Window" BindingSource="bindingSourceHistorico" DisplayMember="historico" Dock="None" Enabled="True" Font="Microsoft Sans Serif, 8.25pt" For 111.668 640.8975 111.1025 640.833 C111.2046 640.9819 111.3047 641.1318 111.1025 641.1675 Cf142.2573 639.8271 m142.0068 640.082 141.9863 640.562 141.9209 640.998 C142.0371 641.1318 142.8569 641.3721 142.9282 640.998 C143.04 640.2725 142.0835 640.6147 142.2573 639.8271 Cf159.0049 640.998 m159.4336 640.9834 159.4028 640.3755 159.1748 640.1621 C158.6489 640.2778 158.9561 640.6094 159.0049 640.998 Cf149.6265 639.6597 m149.2334 639.1475 147.4771 639.1436 147.2832 639.8271 C147.2632 641.2261 149.6426 640.6724 149.6265 639.6597 Cf120.8164 640.3306 m121.6255 640.1348 122.2119 639.7173 122.324