using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TitleSelectRequestMessage : NetworkMessage
	{
		public const uint Id = 6365;

		public uint titleId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6365;
			}
		}

		public TitleSelectRequestMessage()
		{
		}

		public TitleSelectRequestMessage(uint titleId)
		{
			this.titleId = titleId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.titleId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.titleId);
		}
	}
}