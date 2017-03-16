using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class CompassResetMessage : NetworkMessage
	{
		public const uint Id = 5584;

		public sbyte type;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5584;
			}
		}

		public CompassResetMessage()
		{
		}

		public CompassResetMessage(sbyte type)
		{
			this.type = type;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.type = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.type);
		}
	}
}