# ItemHandling
Very simple Sitecore module that removes spaces when an item is added or renamed

Basically this is a VERY simple module that is adapted from another I found that renames Sitecore items that have spaces.
Basically this doesn’t make changes unless the item:added or item:renamed events are triggered.  The item:saved event is so huge that adding something to it really requires a lot of testing.  Also, this is adapted from something I found on someone's blog, but I updated it to do things a little differently. This, of course, is just a simple example and can often times have some other SEO sort of checks/changes made at the same time… but does a simple job without complexities.

Finally, it does not handle any 301 redirects, etc.  It's just a simple class to check for a space in the name
and then rename the item if needed.  Given that there are other modules out there that do that, you'll need to add your own customization to handle that.

