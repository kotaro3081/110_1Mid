< !DOCTYPE html >
 

 < html xmlns = "http://www.w3.org/1999/xhtml" >
  < head runat = "server" >
   < meta http - equiv = "Content-Type" content = "text/html; charset=utf-8" />
        
            < title ></ title >
        </ head >
        < body >
        
            < form id = "form1" runat = "server" >
           
                   < div >
           
                       < h2 > 維修項目單 </ h2 >
           
                       < br />
           
                       < asp:Label ID = "Label1" runat="server" Text="帳號" Font-Size="X-Large"></asp:Label >
              
                          < asp:TextBox ID = "tb_CellPhone" runat="server" Height="15px" Width="200px"></asp:TextBox >< br />
                 
                             < asp:Label ID = "Label2" runat="server" Text="密碼" Font-Size="X-Large"></asp:Label >
                    
                                < asp:TextBox ID = "tb_Pass" runat="server" TextMode="Password" Height="15px" Width="200px"></asp:TextBox >
                       
                                   < asp:Image ID = "Image1" runat="server" Height="30px" ImageAlign="NotSet" Width="30px" ImageUrl="~/eye-slash-solid.svg" /><br />
            <asp:Label ID = "Label3" runat="server" Text="管道得知" Font-Size="X-Large"></asp:Label >
  
              < asp:RadioButtonList ID = "rb_Gender" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                <asp:ListItem > 網頁廣告 </ asp:ListItem >
    
                    < asp:ListItem > 電視 </ asp:ListItem >
         
                         < asp:ListItem > 其他 </ asp:ListItem >
              
                          </ asp:RadioButtonList >< br />
               
                           < asp:Label ID = "Label4" runat="server" Text="影片說明" Font-Size="X-Large"></asp:Label >
                  
                              < asp:HyperLink ID = "HyperLink1" runat="server" ImageUrl="youtube-brands.svg">HyperLink</asp:HyperLink >
                     
                                 < br />
                     
                                 < asp:Label ID = "Label5" runat="server" Text="驗證碼" Font-Size="X-Large"></asp:Label >
                        
                                    < asp:TextBox ID = "TextBox1" runat="server" Width="47px"></asp:TextBox >
                           
                                       < br />
                           
                                       < asp:Button ID = "Button1" runat="server" Height="30px" Text="送出" Width="80px" />
            <br />
        </div>
    </form>
</body>
</html>
