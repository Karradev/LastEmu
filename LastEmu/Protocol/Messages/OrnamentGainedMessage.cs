using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class OrnamentGainedMessage : NetworkMessage
	{
		public const uint Id = 6368;

		public short ornamentId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6368;
			}
		}

		public OrnamentGainedMessage()
		{
		}

		public OrnamentGainedMessage(short ornamentId)
		{
			this.ornamentId = ornamentId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.ornamentId = reader.ReadShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.ornamentId);
		}
	}
}