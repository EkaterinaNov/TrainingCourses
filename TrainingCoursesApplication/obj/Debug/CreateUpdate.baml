   M S B A M L   `   `   `  ����U  QTrainingCoursesApplication, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:TrainingCoursesApplicationTrainingCoursesApplication  5      -    'TrainingCoursesApplication.CreateUpdate   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:TrainingCoursesApplication     5        N� Title$  CreateUpdateStudent��5	       N� 
Background �#E1E7E7.��5      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��6    $
��20 5q�6-   $��Center=�6<   $��Center=�6Y   ���#B9DDCD
���   �$��1q�6�   $��10q�6�   .��5      �� $��Students.xaml?�6   $��Arial)�64   $��18(�6G   
���   � �� TextDecorations$
 none{�6h   .�6   
Students6�   5      �� 5   
   $��1��6   $��0��6    $
��20 5q�6-   $��Center=�6<   $��Center=�6Y   ���#B9DDCD
���   �$��1q�6�   $��10q�6�   .��5      �� $��Courses.xaml?�6   $��Arial)�63   $��18(�6F   
���   �$
 none{�6g   .�6~   	Courses6�   5       �� 5"   
   $��0��6   $��3��6    $
��Name��6-   $��18(�6<   $��Arial)�6J   $��Center=�6]   $��Center=�6x   �� 5#   
   -   5        $��NameTextBox��5#      $��
10 0 100 0q�6%   $��1��69   $��3��6I   $��18(�6V   $��Arial)�6d   $��Center=�6w   6�   �� 5$   
   -   5        $��	NameLabel��5$      $��3��6!   $��1��6.   $��Name field must be filled��6>   $��Center=�6b   $	��Top=�6   $
��0 20q�6�   $��25��6�   $��14(�5%      $��Arial)�6   
���  ��$y�Hidden=�6B   �� 5'   
   -   5        $��CourseLabel��5'      $��0��6#   $��2��63   $��Course��6@   $��18(�6Q   $��Arial)�6_   $��Center=�6r   $��Center=�6�   �� 5(   
   -   5        $��CoursesComboBox��5(      $��1��6*   $��2��6:   $��
10 0 100 0q�6G   $��25��6[   6g   �� 5)   
   -   5        $��CourseMessageLabel��5)      $��2��6*   $��1��67   $��Select course��6G   $��Center=�6_   $	��Top=�6|   $
��0 20q�6�   $��25��6�   $��14(�5*      $��Arial)�6   
���  ��$y�Hidden=�6B   �� 5,   
   -   5        $��CourseCostLabel��5,      $��0��6'   $��2��67   $��Course cost��6D   $��18(�6Z   $��Arial)�6h   $��Center=�6{   $��Center=�6�   �� 5-   
   -   5        $��CoursesCostTextBox��5-      $��1��6,   $��2��6<   $��
10 0 100 0q�6I   $��Arial)�6]   $��18(�6p   $��Center=�6   6�   �� 5.   
   -   5        $��CourseCostMessageLabel��5.      $��2��6.   $��1��6;   $%��Course cost should be indicated��6K   $��Center=�6u   $	��Top=�6�   $
��0 20q�6�   $��25��6�   $��14(�5/      $��Arial)�6   
���  ��$y�Hidden=�6B   �� 51   
   -	   5        $��
EditButton��51      $��2��6#   $��4��67   $
��Edit��6D   $��Center=�6T   $��Center=�6q   ���#66DDAA
���   �$��1q�6�   $��Arial)�52      $��16(�6(   
���   �$
��20 5q�6I   $��10q�6X   6d   �� 54   
   -
   5        $��	AddButton��54      $��2��6"   $��4��66   $	��Add��6C   $��Center=�6R   $��Center=�6o   ���#66DDAA
���   �$��1q�6�   $��Arial)�55      $��16(�6(   
���   �$
��20 5q�6I   $��10q�6X   6d   56      57      