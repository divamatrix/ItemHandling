using System;
using System.Linq;
using Sitecore.Data.Items;
using Sitecore.Events;

namespace ItemHandling
{
    public class ItemNameEventHandler 
    {
        public void HandleItemName(object sender, EventArgs args)
        {
            var item = (Item) Event.ExtractParameter(args, 0);

            if (item.Database.Name != "master" // Check that the item to be edited is in the master db 

                // Check that the item is in the content tree (if desired or can customize this however)
                || !item.Paths.IsContentItem  
                
                // Check if the item name has spaces (this would normally be in a string extension class.. but for the sake of showing the logic)
                || !item.Name.Contains(' '))
            {
                return;
            }
            using (new EditContext(item))
            {
                // Existing name is added to display name field
                item.Appearance.DisplayName = item.Name;
                // Item is given updated name. Adding to ToLower is optional, of course. 
                item.Name = item.Name.ToLower().Replace(' ', '-');    
            }
            
        }
    }
}
