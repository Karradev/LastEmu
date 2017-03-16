using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class StorageInventoryContentMessage : InventoryContentMessage
	{
		public const uint Id = 5646;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5646;
			}
		}

		public StorageInventoryContentMessage()
		{
		}

		public StorageInventoryContentMessage(ObjectItem[] objects, uint kamas) : base(objects, kamas)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}