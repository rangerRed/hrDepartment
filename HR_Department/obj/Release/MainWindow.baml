   M S B A M L   `   `   `  ���� H  DHR_Department, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HR_DepartmentHR_Department      HR_Department.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     -localclr-namespace:HR_Department     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � 
ResizeMode$  NoResize=� � WindowStyle$
 None=� � WindowStartupLocation$ CenterScreen=� � Title$ Login��$	��418��$��733.5��'  !System.Windows.Shell.WindowChrome   WindowChrome      GlassFrameThickness$ 0q�   CornerRadius$ 0��   CaptionHeight$ 0Q�   UseAeroCaptionButtons .  	   ResizeBorderThickness$	 7q�
 � 	Resources
  	  intro �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value   EasingFunction0  *System.Windows.Media.Animation.QuinticEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode��%�   &	        �� .��U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�$ Image��.\�  $ 0:0:1��$	 -48Q�   $ 	EaseInOut=� � Triggers :�  :� RoutedEvent$ FrameworkElement.Loaded��.[��� #��[  .��� -   
�������.+��� -    ��Name$ Image��$
��Left=�$	��652��$��
0,0,0,-263q�$	��Top=�$	��284��$��Resources/Login2.jpg�� J� RenderTransformOrigin$ 0.5,0.5&�z�V� .~��� �� �� T� �� -    ��Name$ label�� �� ClearTypeHint$ Enabled=�$=��7Войдите в свою учетную запись.��$
��Left=�$��
289,76,0,0q�$	��Top=����	#DD000000$��	Open Sans)�$��19(�$��444.5���� -   $ 
label_Copy��$ Enabled=�$��
Логин��$
��Left=�$��339,114.873,0,0q�$	��Top=�
���   �$��	Open Sans)�$��131.943���� -   $ label_Copy1��$ Enabled=�$��Пароль��$
��Left=�$��339,177.216,0,0q�$	��Top=�
���   �$��	Open Sans)��� -    ��Name$ textBox_login��)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��$
��Left=�$��25��$��345,139.273,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��315�����	#7F000000G� -    G�Name$ textBox_password��$ Пароль��$
��Left=�$��25��$��345,206.559,0,0q�$	��Top=�$	��323�����	#7F000000$��	Open Sans)�$ 0.502,0.711&��� -   $ image1��$
��Left=�$��20��$��644,144.216,0,0q�$	��Top=�$��24��$#��Resources/icons8-email-32.png���� -	   $ image1_Copy��$
��Left=�$��20��$��644,206.559,0,0q�$	��Top=�$��24��$"��Resources/icons8-lock-32.png���� -
   $ label_forgotPassword��$ Enabled=�$ ��Забыли пароль?��$
��Left=�$��561.16,236.559,0,0q�$	��Top=����	#FF416CFF$��	Open Sans)� � Cursor$
 Hand����Z� �� -   $��15��$��15��$��Right=�$	��Top=�$��	0,16,31,0q�$.��(Resources/premium-icon-minus-2617259.png���� -    ��Name$ button_login��$��
Войти��$
��Left=�$��345,282,0,0q�$	��Top=�$	��323��$��12(�$��	Open Sans)�$��36����Z� ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&� �� RelativeTransform V� .~���   �� CenterY$	  0.5Q�! �� CenterX$	! 0.5Q��� " �� CenterY$	" 0.5Q�# �� CenterX$	# 0.5Q��� $ �� Angle$	$ -45Q�% �� CenterY$	% 0.5Q�& �� CenterX$	& 0.5Q�T� .��� ' � Color$' 	#FF009EDA��( � Offset$( 0Q�� $' 	#FF00678E��$( 1Q��� -   $��15��$��15��$��1��$��Right=�$	��Top=�$��0��$��	0,11,11,0q�$,��&Resources/icons8-удалить-48.png��