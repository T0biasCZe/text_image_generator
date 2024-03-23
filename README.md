# Text in image generator 3000
Tool for generating images with text for use in datasets for training upscale models
![image](https://github.com/T0biasCZe/text_image_generator/assets/44525446/c9c1af4b-64e5-487b-aad1-33afb2c2ed59)


https://github.com/T0biasCZe/text_image_generator/assets/44525446/77192eea-71cd-4f4b-97ce-5533faf98622

# Properties:   
Colour modes:   
Custom: you can use whatever colour you like   
Random: generates random colour    
Random++: Generates random colour that is high contrast to the second colour. Eg if background is white, it will not generate light blue text colour, or if text is dark blue it will not pick black for background    
you can combine Random++ with Custom colour     

Text render:    
System default - uses default font hinting in windows, will anti aliase the pixels     
Pixelated - will render text without any anti aliasing    

Number of images: how many images to generate    
Start i: at what number will the file names start    

# Batch mode
The program has batch mode that allows you to generate lot of different text images at once, with different colour, size, font etc    
The syntax is 1 type per line, saved in csv like format:    
width;height;font name;font size;foreground_type;custom_foreground;\nbackground_type;custom_background;count;starti;AA_type         
    
So for example:  
1440;1152;PUBLIC PIXEL;20;1;#000000;1;#000000;40;0;2     
1440;1152;PUBLIC PIXEL;36;1;#000000;1;#000000;40;40;2      
1440;1152;PUBLIC PIXEL;36;2;#FFFFFF;2;#0080FF;20;80;2      
1440;1152;Arial;36;1;#000000;1;#000000;40;100;2       
1440;1152;Arial;36;2;#FFFFFF;2;#0080FF;20;140;2       
1440;1152;Times New Roman;36;2;#000000;2;#FFFFFF;20;160;2      
1440;1152;Times New Roman;36;2;#333333;2;#BBBBBB;20;180;2      
1440;1152;Times New Roman;36;2;#333333;1;#BBBBBB;20;200;2        

foreground_type: 0 is random, 1 is random++ and 2 is custom    
AA_type: No AA is 2, Cleartype is 5 and Grayscale AA is 3
