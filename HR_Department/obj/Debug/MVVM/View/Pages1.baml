   M S B A M L   `   `   `  ����H  DHR_Department, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:HR_Department.MVVM.ViewHR_Department.MVVM.View  5      $    HR_Department.MVVM.View.Pages1   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:HR_Department.MVVM.View     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      ��   � 	Resources  5   
    �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius ��Name �� Triggers P� Property	 P� Value
 �� 
TargetName��%:  '��       �� 5      " ��6   .�5      ��  � �� 5      �� 5      " ��6*   .R�5      �� $��Border��6%   $��1,1,1,0q�63   
�������$ 4,4,0,0��6e   $	��2,0q�6|   ._�5   "   �� $ ContentSite��63   $��Center=�6H   $��Center=�6c   $��Header��6�   $
��10,2q�6�   5       5      P� 5   "    �@��
IsSelected	 . . �5   &   �� $
 Border��6-    � ��
 ��·�6W   5   #   P� 5   "    �@��
IsSelected	 .  . �5   &   �� $
 Border��6-    � ��
 �����6W   5   #   5      5      5      5      .@�5    
   �� ��5!      �� 5"      $��3q�6   $"Прием и увольнение6;   ��5$       � 5%      -   5          �Name$ frame1��5%        � NavigationUIVisibility$ Hidden=�6(   5'      �� 5(   
   ��5)      �� 5*      $��3q�6   Личные дела64   ��5,       � 5-      -   5        $ frame2��5-      $ Hidden=�6(   5/      �� 50   
   ��51      �� 52      $��3q�6   Трудовые книжки68   ��54       � 55      -   5        $ frame3��55      $ Hidden=�6(   57      �� 58   
   ��59      �� 5:      $��3q�6   .,Табель рабочего времени6@   ��5<       � 5=      -   5        $ frame4��5=      $ Hidden=�6(   5?      �� 5@   
   ��5A      �� 5B      $��3q�6   График отпусков68   ��5D       � 5E      -   5        $ frame5��5E      $ Hidden=�6(   5G      �� 5H   
   ��5I      �� 5J      $��3q�6   <:Учет лисков нетрудоспособности6G   ��5L       � 5M      -   5        $ frame6��5M      $ Hidden=�6(   5O      �� 5P   
   ��5Q      �� 5R      $��3q�6   :8История трудовой деятельности6F   ��5T       � 5U      -   5        $ frame7��5U      $ Hidden=�6(   5W      5X      5Y      