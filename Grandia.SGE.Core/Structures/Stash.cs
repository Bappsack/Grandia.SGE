namespace Grandia.SGE.Core.Structures
{
    public class Stash
    {
        public class StashItem
        {
            public string? Name { get; set; }
            public uint? Item { get; set; }
            public int? Quantity { get; set; }
        }

        // NOTE: The Stash can contain any Item, the Game Stores only the Quantity in the Save.
        // the first 9 Bytes are unused.
        public static List<StashItem> GetStashedItems()
        {
            List<StashItem> StashItems = new();

            // Get Stash Block
            var StashBlock = Data.SaveBlock.AsSpan(Data.StashQuantityStart, Data.StashQuantityLength).ToArray();

            // We start at 0xA because 0x0-0x09 are unused
            // 511 - "100 Fire Mace" cannot be stored in Stash for some reason while the other 100 Weapons seems to work.
            for (uint i = 0xA; i < Data.StashQuantityLength; i++)
                StashItems.Add(new StashItem { Item = i, Name = Items.GetInventoryItemName(i), Quantity = StashBlock[i] });

            return StashItems;
        }
    }
}
