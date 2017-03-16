using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class KickHavenBagRequestMessage : NetworkMessage
	{
		public const uint Id = 6652;

		public double guestId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6652;
			}
		}

		public KickHavenBagRequestMessage()
		{
		}

		public KickHavenBagRequestMessage(double guestId)
		{
			this.guestId = guestId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.guestId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.guestId);
		}
	}
}