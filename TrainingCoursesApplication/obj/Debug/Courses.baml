   M S B A M L   `   `   `  ����U  QTrainingCoursesApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:TrainingCoursesApplicationTrainingCoursesApplication  5      (    "TrainingCoursesApplication.Courses   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:TrainingCoursesApplication     5        N� Title$  Courses��5	       N� 
Background �#E1E7E7.��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      .+�5   
   �� $��1��6   $��0��6    $��Center=�6-   $��Center=�6J   ���#66DDAA
���   �$��1q�6�   $��Courses��6�   $��Arial)�5      $��18(�6#   
���   �$
��20 5q�6D   �� 5   
   $��0��6   $��0��6    $
��20 5q�6-   $��Center=�6<   $��Center=�6Y   ���#B9DDCD
���   �$��1q�6�   .��5      �� $��Students.xaml?�6   $��Arial)�64   $��18(�6G   
���   � �� TextDecorations$
 none{�6h   .�6   
Students6�   5      �� 5   
   -   5        $��TotalNumCoursesLabel��5       $��2��6   $
��Left=�6<   $��Center=�6W   $��0 5 0 0q�6r   $��Arial)�6�   $��16(�6�   
���   �$��Total number of courses��5      �� 5   
   -   5        $��AmountCoursesLabel��5       $��2��6   $��Right=�6:   $��Center=�6V   $��0 5 30 0q�6q   $��Arial)�6�   $��16(�6�   
���   �6�   &   System.Windows.Controls.DataGrid  5!   
   -   5        $��CoursesDataGrid��5!      $��1��6*   $��2��67      
IsReadOnly . $��Arial)�6]   $��14(�6p      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 150 6~   $��10q�6�   �� 5#   
   $��1��6   $��2��6"   .+�5$      �� -   5        $ ��MostExpensiveCoursesButton��5$      $��Most expensive courses��67   $��Center=�6X   $��Center=�6u   ���#66DDAA
���   �$��1q�5%      $��Arial)�6)   $��16(�6<   
���   �$	��210��6]   $��33��6i   $��5 20 5 5q�6u   6�   �� 5&      -   5        $��CheapestCoursesButton��5&      $��Cheapest courses��62   $��Center=�6M   $��Center=�6j   ���#66DDAA
���   �$��1q�5'      $��Arial)�6)   $��16(�6<   
���   �$	��210��6]   $��33��6i   $��5q�6u   6�   �� 5(      -   5        $!��MostProfitableCoursesButton��5(      $��Most profitable courses��68   $��Center=�6Z   $��Center=�6w   ���#66DDAA
���   �$��1q�5)      $��Arial)�6)   $��16(�6<   
���   �$	��210��6]   $��33��6i   $��5 5 5 15q�6u   6�   �� 5*      -   5        $��ViewAllCoursesButton��5*      $��View all courses��61   $��Center=�6L   $��Center=�6i   ���#66DDAA
���   �$��1q�6�   $��Arial)�5+      $��16(�6(   
���   �$	��210��6I   $��33��6U   $��5 15 5 5q�6a   6s   �� 5,      -   5        $��EditCourseButton��5,      $��Edit course��6-   $��Center=�6C   $��Center=�6`   ���#66DDAA
���   �$��1q�5-      $��Arial)�6)   $��16(�6<   
���   �$	��210��6]   $��33��6i   $��5q�6u   6�   �� 5.      -	   5        $��AddCourseButton��5.      $��
Add course��6,   $��Center=�6A   $��Center=�6^   ���#66DDAA
���   �$��1q�5/      $��Arial)�6)   $��16(�6<   
���   �$	��210��6]   $��33��6i   $��5q�6u   6�   �� 50      -
   5        $��DeleteButton��50      $��Delete course��6)   $��Center=�6A   $��Center=�6^   ���#FFB5B2
���   �$��1q�51      $��Arial)�6)   $��16(�6<   
���   �$	��210��6]   $��33��6i   $��5q�6u   6�   �� 52      -   5        $��EditCourseLabel��52      $!��Select course from the list��6+   $��Center=�6Q   $��Center=�6n   $��Arial)�53      $��14(�6(   
���  ��$y�Hidden=�6G   54      56      57      