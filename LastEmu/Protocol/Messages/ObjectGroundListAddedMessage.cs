using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectGroundListAddedMessage : NetworkMessage
	{
		public const uint Id = 5925;

		public uint[] cells;

		public uint[] referenceIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5925;
			}
		}

		public ObjectGroundListAddedMessage()
		{
		}

		public ObjectGroundListAddedMessage(uint[] cells, uint[] referenceIds)
		{
			this.cells = cells;
			this.referenceIds = referenceIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.cells = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.cells[i] = reader.ReadVarUhShort();
			}
			num = reader.ReadUShort();
			this.referenceIds = new uint[num];
			for (int j = 0; j < num; j++)
			{
				this.referenceIds[j] = reader.ReadVarUhShort();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.cells.Length));
			uint[] numArray = this.cells;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarShort((int)numArray[i]);
			}
			writer.WriteShort((short)((int)this.referenceIds.Length));
			uint[] numArray1 = this.referenceIds;
			for (int j = 0; j < (int)numArray1.Length; j++)
			{
				writer.WriteVarShort((int)numArray1[j]);
			}
		}
	}
}