using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameDataPaddockObjectListAddMessage : NetworkMessage
	{
		public const uint Id = 5992;

		public PaddockItem[] paddockItemDescription;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5992;
			}
		}

		public GameDataPaddockObjectListAddMessage()
		{
		}

		public GameDataPaddockObjectListAddMessage(PaddockItem[] paddockItemDescription)
		{
			this.paddockItemDescription = paddockItemDescription;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.paddockItemDescription = new PaddockItem[num];
			for (int i = 0; i < num; i++)
			{
				this.paddockItemDescription[i] = new PaddockItem();
				this.paddockItemDescription[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.paddockItemDescription.Length));
			PaddockItem[] paddockItemArray = this.paddockItemDescription;
			for (int i = 0; i < (int)paddockItemArray.Length; i++)
			{
				paddockItemArray[i].Serialize(writer);
			}
		}
	}
}