# WPFToastMessage
A toast message popup that fills the empty space in the WPF toolbox

This is an asset for WPF development in C# that adds a modeless way of
notifying the user of changes in your application. It is extremely simple
to use, as easy as the good old "MessageBox.Show("Hello World");" in 
Windows Forms.

To show a toast notification using my implementation, simply write
``` C#
ToastMessage.Show("Message");
```

### Installation
To use this toast class, all you have to do is to add the ToastMessage window
into your application solution, and you're done!

### Usage
The usage is very simple, and the Show method takes for different types of
parameters:
``` C#
ToastMessage.Show("Message");
ToastMessage.Show("Message", "Title");
ToastMessage.Show("Message", "Title", 3);
ToastMessage.Show("Message", "Title", 3, ToastMessage.Position.TOP_RIGHT);
```
These are pretty self explainatory, but basically the first parameter is the message,
the second parameter is the title (default: "Notification"), the third paramter is 
the delay in seconds before the toast disappears (default: 3) and the fourth paramter
is an enum describing where the toast will show. There are 4 defined positions
currently implemented:
- TOP_RIGHT
- TOP_LEFT
- BOTTOM_RIGHT
- BOTTOM_LEFT
