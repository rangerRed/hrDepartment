   M S B A M L   `   `   `  ����H  DHR_Department, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HR_DepartmentHR_Department  5   	       HR_Department.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:HR_Department     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	     � 
ResizeMode$  NoResize=�5   	    � WindowStyle$
 None=�6    � WindowStartupLocation$ CenterScreen=�62    � Title$ Login��5
   	   $	��418��6   $��733.5��6$   '  !System.Windows.Shell.WindowChrome   WindowChrome 5        5   
      GlassFrameThickness$ 0q�6      CornerRadius$ 0��6/      CaptionHeight$ 0Q�6@      UseAeroCaptionButtons .  	   ResizeBorderThickness$	 7q�6p   
 � 	Resources
 5       	  intro �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction0  *System.Windows.Media.Animation.QuinticEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode��%  &	        �� 5   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $ Image��6�   .\�5        $ 0:0:1��6'   $	 -48Q�67    5        5      $ 	EaseInOut=�6&   5      5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� #��[  6   5      .��5       � -   5        
�������.+�5!   
   �� -   5         ��Name$ Image��5!      $
��Left=�6   $	��652��6:   $��
0,0,0,-263q�6G   $	��Top=�6[   $	��284��6s   $��Resources/Login2.jpg��6    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5"      V� 5#      .~�5$      �� �� 5%      �� 5&      T� 5'      5(      5*      �� 5+   
   -   5         ��Name$ label��5+   6    �� ClearTypeHint$ Enabled=�6   $=��7Войдите в свою учетную запись.��6E   $
��Left=�6n   $��
289,76,0,0q�6�   $	��Top=�6�   ���	#DD000000$��	Open Sans)�6�   $��19(�6�   $��444.5��6�   �� 5,   
   -   5        $ 
label_Copy��5,   6   $ Enabled=�6   $��
Логин��6J   $
��Left=�6Z   $��339,114.873,0,0q�6u   $	��Top=�6�   
���   �$��	Open Sans)�6�   $��131.943��6�   �� 5-   
   -   5        $ label_Copy1��5-   6   $ Enabled=�6   $��Пароль��6K   $
��Left=�6\   $��339,177.216,0,0q�6w   $	��Top=�6�   
���   �$��	Open Sans)�6�   �� 5.   
   -   5         ��Name$ textBox_login��5.      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��6)   $
��Left=�6P   $��25��6k   $��345,139.273,0,0q�6w    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��315��6�   ���	#7F0000006�   G� 5/   
   -   5         G�Name$ textBox_password��5/      $ Пароль��60   $
��Left=�6X   $��25��6s   $��345,206.559,0,0q�6   $	��Top=�6�   $	��323��6�   ���	#7F000000$��	Open Sans)�6�   $ 0.502,0.711&�6�   �� 50   
   -   5        $ image1��50      $
��Left=�6    $��20��6;   $��644,144.216,0,0q�6G   $	��Top=�6`   $��24��6x   $#��Resources/icons8-email-32.png��6�   �� 51   
   -	   5        $ image1_Copy��51      $
��Left=�6%   $��20��6@   $��644,206.559,0,0q�6L   $	��Top=�6e   $��24��6}   $"��Resources/icons8-lock-32.png��6�   �� 52   
   -
   5        $ label_forgotPassword��52   L   $ Enabled=�6&   $ ��Забыли пароль?��6j   $
��Left=�6�   $��561.16,236.559,0,0q�6�   $	��Top=�6�   ���	#FF416CFF$��	Open Sans)�6�    � Cursor$
 Hand��6  ��6   Z� 6  �� 53   
   -   5        $��15��53      $��15��6   $��Right=�6<   $	��Top=�6X   $��	0,16,31,0q�6p   $.��(Resources/premium-icon-minus-2617259.png��6�   �� 54   
   -   5         ��Name$ button_login��54      $��
Войти��65   $
��Left=�6E   $��345,282,0,0q�6`   $	��Top=�6u   $	��323��6�   $��12(�6�   $��	Open Sans)�6�   $��36��6�   ��6�   Z� ��55      �� 56       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67    �� RelativeTransform 57      V� 58      .~�59      ��   �� CenterY$	  0.5Q�6-   ! �� CenterX$	! 0.5Q�6;   �� 5:      " �� CenterY$	" 0.5Q�6,   # �� CenterX$	# 0.5Q�6:   �� 5;      $ �� Angle$	$ -45Q�6.   % �� CenterY$	% 0.5Q�6:   & �� CenterX$	& 0.5Q�6H   T� 5<      5=      .��5?      � ' � Color$' 	#FF009EDA��6#   ( � Offset$( 0Q�65   � 5@      $' 	#FF00678E��6#   $( 1Q�65   5A      5C      �� 5D   
   -   5        $��15��5D      $��15��6   $��1��68   $��Right=�6H   $	��Top=�6d   $��0��6|   $��	0,11,11,0q�6�   $,��&Resources/icons8-удалить-48.png��6�   5E      5F      