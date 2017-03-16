using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PaddockMoveItemRequestMessage : NetworkMessage
	{
		public const uint Id = 6052;

		public uint oldCellId;

		public uint newCellId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6052;
			}
		}

		public PaddockMoveItemRequestMessage()
		{
		}

		public PaddockMoveItemRequestMessage(uint oldCellId, uint newCellId)
		{
			this.oldCellId = oldCellId;
			this.newCellId = newCellId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.oldCellId = reader.ReadVarUhShort();
			this.newCellId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.oldCellId);
			writer.WriteVarShort((int)this.newCellId);
		}
	}
}