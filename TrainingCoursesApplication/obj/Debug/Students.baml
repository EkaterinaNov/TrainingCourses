   M S B A M L   `   `   `  ����U  QTrainingCoursesApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:TrainingCoursesApplicationTrainingCoursesApplication  5      )    #TrainingCoursesApplication.Students   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:TrainingCoursesApplication     5        N� Title$  Students��5	       N� 
Background �#E1E7E7.��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��0��6   $��0��6    $��Center=�6-   $��Center=�6J   ���#66DDAA
���   �$��1q�6�   $��Students��6�   $��Arial)�5      $��18(�6#   
���   �$
��20 5q�6D   �� 5   
   $��1��6   $��0��6    $
��20 5q�6-   $��Center=�6<   $��Center=�6Y   ���#B9DDCD
���   �$��1q�6�   .��5      �� $��Courses.xaml?�6   $��Arial)�63   $��18(�6F   
���   � �� TextDecorations$
 none{�6g   .�6~   	Courses6�   5      �� 5   
   -   5        $��TotalNumStudentsLabel��5       $��2��6   $
��Left=�6=   $��Center=�6X   $��0 5 0 0q�6s   $��Arial)�6�   $��16(�6�   
���   �$��Total number of students��6�   �� 5   
   -   5        $��AmountStudentsLabel��5       $��2��6   $��Right=�6;   $��Center=�6W   $��0 5 30 0q�6r   $��Arial)�6�   $��16(�6�   
���   �6�   &   System.Windows.Controls.DataGrid  5!   
   -   5        $��StudentsDataGrid��5!      $��1��6+   $��2��68      
IsReadOnly . $��Arial)�6^   $��14(�6q      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 150 6   $��10q�6�   �� 5#   
   $��1��6   $��2��6"   .+�5$      �� -   5        $��ViewAllStudentsButton��5$      $��View all students��62   $��Center=�6N   $��Center=�6k   ���#66DDAA
���   �$��1q�6�   $��Arial)�5%      $��16(�6(   
���   �$	��153��6I   $��33��6U   $��5 20 5 5q�6a   6s   �� 5&      -   5        $��EditStudentButton��5&      $��Edit student��6.   $��Center=�6E   $��Center=�6b   ���#66DDAA
���   �$��1q�6�   $��Arial)�5'      $��16(�6(   
���   �$	��153��6I   $��33��6U   $��5q�6a   6l   �� 5(      -   5        $��AddStudentButton��5(      $��Add student��6-   $��Center=�6C   $��Center=�6`   ���#66DDAA
���   �$��1q�6�   $��Arial)�5)      $��16(�6(   
���   �$	��153��6I   $��33��6U   $��5q�6a   6l   �� 5*      -   5        $��DeleteStudentButton��5*      $��Delete student��60   $��Center=�6I   $��Center=�6f   ���#FFB5B2
���   �$��1q�6�   $��Arial)�5+      $��16(�6(   
���   �$	��153��6I   $��33��6U   $��5q�6a   6l   �� 5,      -   5        $��EditStudentLabel��5,      $"��Select student from the list��6,   $��Center=�6S   $��Center=�6p   $��Arial)�5-      $��14(�6(   
���  ��$y�Hidden=�6G   5/      50      51      