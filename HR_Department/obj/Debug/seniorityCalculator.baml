   M S B A M L   `   `   `  ����H  DHR_Department, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HR_DepartmentHR_Department  5   	   '    !HR_Department.SeniorityCalculator   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:HR_Department     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � WindowStyle$
 None=�6.    � 
ResizeMode$ NoResize=�6A   
������  � AllowsTransparency .  � Title$ seniorityCalculator��5   	   $	��350��6%   $	��627��62   .��5      �� -   5        
������� �� CornerRadius$ 7��5   $   ._�5   
   �  � RowDefinitions 5      �� 5      $��70 �6    �� 5      $	��230 �6    �� 5      $��50 �6    .+�5      �� -   5        $��15��5      $��15��6    $��Right=�6<   $	��Top=�6X   $��	0,11,11,0q�6p   $,��&Resources/icons8-удалить-48.png��6�   �� 5      $��Рассчет стажа��6   $
��Left=�6-   $	��Top=�6H   $��10q�6`   $��14(�6l   �� 5      $-��'Дата приема на работу��6   $
��Left=�65   $	��Top=�6P   $��
110,40,0,0q�6h   $��14(�6|   �� 5      $3��-Дата увольнения с работы��6   $
��Left=�68   $	��Top=�6S   $��
304,41,0,0q�6k   $��14(�6   �� 5      -   5         ��Name$ temptb��5   *   $y�Hidden=�6   $�� ��6:   �� 5      $��1��6   $
��Auto=�6(   .��5      �� -   5         ��Name$ MyPanel��5      .+�5      � .+�5      (  "System.Windows.Controls.DatePicker  -   5        	  Name$	 datePick1_1��5   %   $	��160��6:   $
��Left=�6F   $��109,10,0,10q�6a     5      -   5        $	 datePick2_1��5   %   $	��160��6:   $
��Left=�6F   $��300,14,20,14q�6a   �� 5      -   5        
 ��Name$
 V1��5   #   $��480,15,105,15q�6/   �� 5      -   5        $
 V2��5   #   $��510,15,75,15q�6/   �� 5       $��V1��6$   $��484,30,100,5q�6.   �� 5!      $��V2��6$   $��514,30,75,5q�6.   5"      5#      5$      �� 5%      -	   5         ��Name$ But_add��5%   A   ���#00678E$��32��6R   $
��Left=�6]   $��	20,8,20,8q�6x   $��2��6�   .��5&      �� $	��-14q�6   $"��/Resources/icons8-add-64.png��6%   5'      �� 5(      -
   5        $ but_del1��5(   \   ���#00678E$'��!Удалить последнее��6@   $
��Left=�6n   $��2��6�   $��	69,10,0,8q�6�   �� 5)      -   5        ���#00678E$��2��5)   +   $��Рассчитать��68   $��Right=�6M   $��10q�6i   $	��110��6�   �� 5*      -   5        $
 VTB1��5*   #   $��2��6   $y�Hidden=�61   �� 5+      -   5        $
 VTB2��5+   #   $��2��6   $y�Hidden=�61   �� 5,      -   5        $
 VTB3��5,   #   $��2��6   $y�Hidden=�61   5-      5.      5/      