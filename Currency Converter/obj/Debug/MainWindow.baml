   M S B A M L   `   `   `  ����M  ICurrency Converter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Currency_ConverterCurrency_Converter  5   	   #    Currency_Converter.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   \ XHardcodet.Wpf.TaskbarNotification, Version=1.0.5.0, Culture=neutral, PublicKeyToken=null)tb http://www.hardcodet.net/taskbar  5   	   ,local clr-namespace:Currency_Converter  5   	   V RMaterialDesignThemes.Wpf, Version=3.1.1.1361, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          �Name$  MainForm��5   1    � AllowsTransparency .  � WindowStyle$
 None=�5	   #    � 
ResizeMode$ NoResize=�66      MaterialDesignBody#���   5   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	     WindowStyle#���  5   	    � Title$ MainForm��5   	   $	��780��6   $	��580��6'   $	��550��5      $	��750��5   	    � WindowStartupLocation$ CenterScreen=�6   $y�Visible=�5   	   ��5   	   Z�  � 	Resources 5      	 �� 
TargetType
 �� Triggers :� RoutedEvent �� TargetProperty W� From	 W� To g� Duration  	TabButton �� Property �� Value �� 
TargetType �� CornerRadius ��Name��%1  &	       &	 �     �� 5   
   "	 �6$   
 5      :� 5      $ Loaded��6   [�5      �� 5      .��5      �� .��5   "   W� $ Opacity�5   !   $ 0X�5    !   $ 1X�5!   !   $ 0:0:0.5D�5"   !   5#      5$      5&      5(      �� 5*   
   "	 ��6   .�5+      ��  � ��
 �  ��6+   �� 5,       � �� 5-      �� 5.      " ��6&   .R�5/      �� $ 0��6!   ���#2ecc71$��0q�50   !   $��30��65   $��30��6A   ._�51      �� $ contentPresenter��6/   52      53      55      56      57       J� Effect 58      3  -System.Windows.Media.Effects.DropShadowEffect  59   
      
BlurRadius$ 15Q�6      RenderingBias$ Quality=�6+      ShadowDepth$ 0Q�6C      Opacity$	 0.5Q�6S   .��5<      � -   5         �Name$ MainGrid��5<      $��15q�5=   *   .+�5?   
   3  -Hardcodet.Wpf.TaskbarNotification.TaskbarIcon  -   5          Name$
 Tray��5?      $y�Hidden=�5@         ToolTipText$ Currency converter��5A         
IconSource$ Resources/Logo.ico��5B       � ContextMenu 5D      �� 5E      .@�5F      m� -   5        $��Курсы валют��5F      64   m� 5G      -   5        $'��!Калькулятор валют��5G      6:   �� 5H      m� 5I      -   5        $#��Настройки валют��5I      68   m� 5J      -   5        $-��'Настройки приложения��5J      6=   �� 5K      m� 5L      -   5        $��
Выход��5L      6/   5M      5O      �� 5Q   
   -	   5         ��Name$
 Back��5Q        �� RadiusX$  20��6"   ! �� RadiusY$! 20��6/   ��6<   �� *color+" �� FallbackValue$" White���� 5U   
   ���#2ecc71$ 20,0,0,0��5V      $��0q�5W      $
��Left=�5X      $	��Top=�5Y      $��30��5Z      $	��405��6   $��0,0,0,0q�5[      �� 5\   
   -
   5        
���   �# � Cursor$
# Hand��5]      $��1��5^      $	��Top=�5_      $��Right=�5`      $��	0,0,120,0q�5a      #��[ 5b      .��5c      �� 
���   �$��1,0,0,0q�6)   ._�5d      �� $��14(�6   $��Center=�5e      $��Center=�5f      .��5g      '  !MaterialDesignThemes.Wpf.PackIcon  $   Kind$$ Money=�6.   $��20��6;   $��20��6G   5h      5i      5j      �� 5k   
   -   5        
���   �$
# Hand��5l      $��1��5m      $	��Top=�5n      $��Right=�5o      $��0,0,90,0q�5p      #��[ 5q      .��5r      �� 
���   �$��1,0,1,0q�6)   ._�5t      �� $��14(�6   $��Center=�5u      $��Center=�5v      .��5w        $$ Settings=�6.   $��18��6>   $��18��6J   5x      5y      5z      �� 5{   
   -   5        $��0q�5{      $
# Hand��5|      $��2��5}      $	��Top=�5~      $��Right=�5      $��0,0,60,0q�5�      #��[ 5�      .��5�      �� 
���   �$��0,0,1,0q�6)   ._�5�      � % K� ZIndex$% 1��6   $	��Top=�5�      $
��Left=�5�      $��30��5�      $��30��6#   .+�5�      �� 	& �� X1$& 8��6   	' �� Y1$' 12��6"   	( �� X2$( 15��6*   	) �� Y2$) 18��62   
���   �6:   �� 5�      $& 22��6   $' 12��6#   $( 15��6+   $) 18��63   
���   �6;   5�      5�      5�      �� 5�   
   -   5        $��0q�5�      $
# Hand��5�      $��3��5�      $	��Top=�5�      $��Right=�5�      $��0,0,30,0q�5�      #��[ 5�      .��5�      �� 
���   �$��0,0,1,0q�6)   ._�5�      � $% 1��6   $	��Top=�5�      $
��Left=�5�      $��30��5�      $��30��6#   .+�5�      �� $& 8��6   $' 15��6"   $( 22��6*   $) 15��62   
���   �6:   5�      5�      5�      �� 5�   
   -   5        * ��Name$* 	CloseForm��5�      $��30��5�      $��30��6   $��0,0,0,0q�5�      $	��Top=�5�      $��Right=�5�      ��5�      �� 5�      .R�5�      �� $ 0,20,0,0��6   ���#2ecc71._�5�      � $% 1��6    $��Bottom=�5�      $
��Left=�5�      $��30��5�      $��30��6+   .+�5�      �� $& 8��6#   $' 8��6*   $( 22��61   $) 22��69   
���   �6A   �� 5�      $& 22��6#   $' 8��6+   $( 8��62   $) 22��69   
���   �6A   5�      5�      5�      5�      � 5�   
   -   5        $ Loader��5�   (   .+�5�       � -   5        +  �Name$+ Page_Loader��5�   -   ,  � NavigationUIVisibility$, Hidden=�6B   5�      � 5�   
   $��50��6   $��Bottom=�6   
������ - � ColumnDefinitions- 5�      �� 5�      �� 5�      .+�5�      �� -   5        $* Course��5�      $��50��5�      $��1��5�      $��0��6"   $	��500��5�      ��5�      �� 5�      .R�5�      (  "MaterialDesignThemes.Wpf.ColorZone  $
��Left=�63   +  %MaterialDesignThemes.Wpf.ShadowAssist.   ShadowDepth$. Depth2=�5�   5   /   CornerRadius$/ 	20,0,0,20��5�   5   ���#2ecc71$��0,0,1,0q�5�   5   
���   �$	��275��5�   5   $��50��6A   $��1��6M   .��5�      �� 
���   �$��Center=�5�   %   $��Center=�5�   %   $��20(�5�   %   .��63   Курсы валют5�      5�      5�      5�      �� 5�      -   5        $* 
Calcutator��5�      $��50��5�      $��1��5�      $��0q�6"   $��1��5�      $	��500��5�      ��5�      �� 5�      .R�5�        $
��Left=�63   $. Depth2=�5�   !   $/ 	0,20,20,0��5�   !   ���#2ecc71$��1,0,0,0q�5�   !   
���   �$	��275��5�   !   $��50��6-   $��1��69   .��5�      �� 
���   �$��Center=�5�   !   $��Center=�5�   !   $��20(�5�   !   .��6/   #!Калькулятор валют5�      5�      5�      5�      5�      5�      5�      