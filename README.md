# ItemHandling
Very simple Sitecore module that removes spaces when an item is added or renamed

Basically this is a VERY simple module that is adapted from another I found that renames Sitecore items that have spaces.

This is just a very simple class that is triggered by item:Added and item:Renamed events.  It's not meant to rename
any items.  It does not handle any 301 redirects, etc.  It's just a simple class to check for a space in the name
and then rename the item if needed.
