   M S B A M L   `   `   `  ����F  BWpfAnimacao, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WpfAnimacaoWpfAnimacao  5   	       WpfAnimacao.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WpfAnimacao     5   	     � Title$  
MainWindow��5   	   $	��320��6   $	��400��6)   .��5	      � .+�5
   
   �� -   5        $��
rectangulo��5
      
����  �$��10,10,10,10q�62    � Triggers 5      :� 5       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� .��5      �� .��5      W�  �� 
TargetName$ 
rectangulo��5   !    �� TargetProperty$ Opacity�6D    W� From 1.06h   	 W� To 0.06s    g� Duration$ 0:0:4D�6|    g� AutoReverse$
 True��6�   	 g� RepeatBehavior$	 Forever��6�   5      5      5      5      5      5      