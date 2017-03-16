using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class OrnamentSelectRequestMessage : NetworkMessage
	{
		public const uint Id = 6374;

		public uint ornamentId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6374;
			}
		}

		public OrnamentSelectRequestMessage()
		{
		}

		public OrnamentSelectRequestMessage(uint ornamentId)
		{
			this.ornamentId = ornamentId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.ornamentId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.ornamentId);
		}
	}
}