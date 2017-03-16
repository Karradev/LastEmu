using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ObjectUseOnCellMessage : ObjectUseMessage
	{
		public const uint Id = 3013;

		public uint cells;

		public override uint ProtocolId
		{
			get
			{
				return (uint)3013;
			}
		}

		public ObjectUseOnCellMessage()
		{
		}

		public ObjectUseOnCellMessage(uint objectUID, uint cells) : base(objectUID)
		{
			this.cells = cells;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.cells = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarShort((int)this.cells);
		}
	}
}