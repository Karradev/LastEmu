using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuestModeMessage : NetworkMessage
	{
		public const uint Id = 6505;

		public bool active;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6505;
			}
		}

		public GuestModeMessage()
		{
		}

		public GuestModeMessage(bool active)
		{
			this.active = active;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.active = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.active);
		}
	}
}