   M S B A M L   `   `   `  ���� H  DHR_Department, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HR_DepartmentHR_Department  $    HR_Department.dismiss_employee   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:HR_Department     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � 
ResizeMode$  NoResize=� � WindowStartupLocation$ CenterScreen=� � WindowStyle$
 None=� � AllowsTransparency .  � Title$ dismiss_employee��$	��350��$	��600��
������ .���� -   
������� �� CornerRadius$ 7��._�� .+��� -   $��15��$��15��$��Right=�$	��Top=�$��	0,11,11,0q�$,��&Resources/icons8-удалить-48.png���� $#��Дата увольнения��$
��Left=�$	��Top=�$��30q�(  "System.Windows.Controls.DatePicker  -     Name$ date_dismissed��$	��150��$
��Left=�$	��Top=�$��30,50q��� $-��'Основание увольнения��$
��Left=�$	��Top=�$��30,90q��� $��Статья��$
��Left=�$	��Top=�$��
400,90,0,0q��� $��
Пункт��$
��Left=�$	��Top=�$��
490,90,0,0q��� $9��3Номер приказа на увольнение��$
��Left=�$	��Top=�$��
30,150,0,0q��� $7��1Дата приказа на увольнение��$
��Left=�$	��Top=�$��245,150,0,0q��� -    ��Name$ grounds��$	��360��$
��Left=�$	��Top=�$��30,110q��� -   $ article��$��80��$
��Left=�$	��Top=�$��400,110,0,0q��� -   $ 	paragraph��$	��Top=�$��490,110,0,0q�$
��Left=�$��80���� -   $ order_number��$	��Top=�$��
30,170,0,0q�$
��Left=�$	��170��  -   $ date_order_dismissed��$	��Top=�$��245,170,0,0q�$
��Left=�$	��160���� -	   ���#00678E$��Уволить��$��Bottom=�$��20q�$��Right=��� -
   ���#00678E$��Печать��$��Bottom=�$��
0,0,120,20q�$��Right=�