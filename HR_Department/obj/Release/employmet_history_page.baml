   M S B A M L   `   `   `  ���� H  DHR_Department, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:HR_DepartmentHR_Department  *    $HR_Department.employmet_history_page   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     -localclr-namespace:HR_Department     _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    N� 
Background
  ����� N� Title$ employmet_history_page��.��� .+��� $��ФИО��$��24(�$
��Left=�$	��Top=�$��30q��� -    ��Name$
 name��$�� ��$��24(�$
��Left=�$	��Top=�$��100,30q�&   System.Windows.Controls.DataGrid  -     Name$" data_grid_history_employment��   
IsReadOnly .    AutoGenerateColumns .  $��30,100,30,150q�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   
Visibility$ Hidden=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ID+  $ Hidden=� �� *Код_сотрудника+  	   Header$	 №пп�� �� *	№пп+  $	 Дата�� �� *
Дата+  $Q	 KСведения о приеме переводах и увольнении�� �� *MKСведения о приеме переводах и увольнении+  $1	 +Основание наименование�� �� *,*ОснованиеНаименование+  $!	 Основание дата�� �� *ОснованиеДата+  $#	 Основание номер�� �� *ОснованиеНомер+  $#	 Основание серия�� �� *ОснованиеСерия+  $6	 0Вид кадрового мероприятия�� �� *20Вид кадрового мероприятия+  $B	 <Статья ФЗ причины при увольнении�� �� *><Статья ФЗ причины при увольнении+  $@	 :Пункт ФЗ причины при увольнении�� �� *<:Пункт ФЗ причины при увольнении+  $+	 %Выполняемая функция�� �� *><выполняемая функция(при наличии)+  $	 С даты�� �� *С даты+  $	 По дату�� �� *по дату+  $.	 (Признак отмены записи�� �� **(признак отмены записи+  $(	 "Дата отмены записи�� �� *$"дата отмены записи+  $	 Совместитель�� �� *совместитель+  $	 Должность�� �� *должность+  $	 
Отдел�� �� *
отдел+  $B	 <Работа в районах крайнего севера�� �� *><работа в районах крайнего севера+  $
	 UUID�� �� *UUID+�� -   
 ��Name$	
 add�����#00678E$��Добавить��$��18(�$��Right=�$��Bottom=�$��30,60q��� -   $	
 del�����#00678E$��Удалить��$��18(�$��Right=�$��Bottom=�$��290,60q��� -   $
 update�����#00678E$��Изменить��$��18(�$��Right=�$��Bottom=�$��160,60q��� -   $

 exit�����#00678E$��
Выход��$��18(�$
��Left=�$��Bottom=�$��30,60q��� -   $��1��
�������$��37��$��37��$��
0,0,400,57q�$��Bottom=�$��Right=�.���� $F��@/Resources/icons8-доступные-обновления-30.png��$��25��$��25��$	��-20q�