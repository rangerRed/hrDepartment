   M S B A M L   `   `   `  ���� H  DHR_Department, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HR_DepartmentHR_Department  '    !HR_Department.SeniorityCalculator   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:HR_Department     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � WindowStartupLocation$  CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�
������  � AllowsTransparency .  � Title$ seniorityCalculator��$	��350��$	��627��.���� -   
������� �� CornerRadius$ 7��._��  � RowDefinitions �� $��70 ��� $	��230 ��� $��50 �.+��� -   $��15��$��15��$��Right=�$	��Top=�$��	0,11,11,0q�$,��&Resources/icons8-удалить-48.png���� $��Рассчет стажа��$
��Left=�$	��Top=�$��10q�$��14(��� $-��'Дата приема на работу��$
��Left=�$	��Top=�$��
110,40,0,0q�$��14(��� $3��-Дата увольнения с работы��$
��Left=�$	��Top=�$��
304,41,0,0q�$��14(��� -    ��Name$ temptb��$y�Hidden=�$�� ���� $��1��$
��Auto=�.���� -    ��Name$ MyPanel��.+�� .+�(  "System.Windows.Controls.DatePicker  -   	  Name$	 datePick1_1��$	��160��$
��Left=�$��109,10,0,10q�  -   $	 datePick2_1��$	��160��$
��Left=�$��300,14,20,14q��� -   
 ��Name$
 V1��$��480,15,105,15q��� -   $
 V2��$��510,15,75,15q��� $��V1��$��484,30,100,5q��� $��V2��$��514,30,75,5q��� -	    ��Name$ But_add�����#00678E$��32��$
��Left=�$��	20,8,20,8q�$��2��.���� $	��-14q�$"��/Resources/icons8-add-64.png���� -
   $ but_del1�����#00678E$'��!Удалить последнее��$
��Left=�$��2��$��	69,10,0,8q��� -   ���#00678E$��2��$��Рассчитать��$��Right=�$��10q�$	��110���� -   $
 VTB1��$��2��$y�Hidden=��� -   $
 VTB2��$��2��$y�Hidden=��� -   $
 VTB3��$��2��$y�Hidden=�