   M S B A M L   `   `   `  ����H  DHR_Department, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HR_DepartmentHR_Department  5   	   $    HR_Department.dismiss_employee   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:HR_Department     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�6    � WindowStyle$
 None=�6D    � AllowsTransparency .  � Title$ dismiss_employee��5
   	   $	��350��6"   $	��600��6/   
������ .��5      �� -   5        
������� �� CornerRadius$ 7��5   %   ._�5   
   � .+�5      �� -   5        $��15��5      $��15��6    $��Right=�6<   $	��Top=�6X   $��	0,11,11,0q�6p   $,��&Resources/icons8-удалить-48.png��6�   �� 5      $#��Дата увольнения��6   $
��Left=�6/   $	��Top=�6J   $��30q�6b   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ date_dismissed��5      $	��150��61   $
��Left=�6=   $	��Top=�6X   $��30,50q�6p   �� 5      $-��'Основание увольнения��6   $
��Left=�64   $	��Top=�6O   $��30,90q�6g   �� 5      $��Статья��6   $
��Left=�6&   $	��Top=�6A   $��
400,90,0,0q�6Y   �� 5      $��
Пункт��6   $
��Left=�6%   $	��Top=�6@   $��
490,90,0,0q�6X   �� 5      $9��3Номер приказа на увольнение��6   $
��Left=�6;   $	��Top=�6V   $��
30,150,0,0q�6n   �� 5      $7��1Дата приказа на увольнение��6   $
��Left=�6:   $	��Top=�6U   $��245,150,0,0q�6m   �� 5      -   5         ��Name$ grounds��5      $	��360��6'   $
��Left=�63   $	��Top=�6N   $��30,110q�6f   �� 5      -   5        $ article��5      $��80��6'   $
��Left=�62   $	��Top=�6M   $��400,110,0,0q�6e   �� 5      -   5        $ 	paragraph��5      $	��Top=�6)   $��490,110,0,0q�6A   $
��Left=�6V   $��80��6q   �� 5      -   5        $ order_number��5      $	��Top=�6,   $��
30,170,0,0q�6D   $
��Left=�6X   $	��170��6s     5      -   5        $ date_order_dismissed��5      $	��Top=�67   $��245,170,0,0q�6O   $
��Left=�6d   $	��160��6   �� 5      -	   5        ���#00678E$��Уволить��5   +   $��Bottom=�6=   $��20q�6h   $��Right=�6t   �� 5      -
   5        ���#00678E$��Печать��5   +   $��Bottom=�6<   $��
0,0,120,20q�6e   $��Right=�6y   5      5      5      