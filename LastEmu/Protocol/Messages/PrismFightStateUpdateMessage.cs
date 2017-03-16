using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismFightStateUpdateMessage : NetworkMessage
	{
		public const uint Id = 6040;

		public sbyte state;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6040;
			}
		}

		public PrismFightStateUpdateMessage()
		{
		}

		public PrismFightStateUpdateMessage(sbyte state)
		{
			this.state = state;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.state = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.state);
		}
	}
}