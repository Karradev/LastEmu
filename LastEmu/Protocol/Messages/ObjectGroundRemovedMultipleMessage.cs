using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ObjectGroundRemovedMultipleMessage : NetworkMessage
	{
		public const uint Id = 5944;

		public uint[] cells;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5944;
			}
		}

		public ObjectGroundRemovedMultipleMessage()
		{
		}

		public ObjectGroundRemovedMultipleMessage(uint[] cells)
		{
			this.cells = cells;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.cells = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.cells[i] = reader.ReadVarUhShort();
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
		}
	}
}