using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TeleportHavenBagRequestMessage : NetworkMessage
	{
		public const uint Id = 6647;

		public double guestId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6647;
			}
		}

		public TeleportHavenBagRequestMessage()
		{
		}

		public TeleportHavenBagRequestMessage(double guestId)
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