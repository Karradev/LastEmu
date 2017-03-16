using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class CompassUpdatePartyMemberMessage : CompassUpdateMessage
	{
		public const uint Id = 5589;

		public double memberId;

		public bool active;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5589;
			}
		}

		public CompassUpdatePartyMemberMessage()
		{
		}

		public CompassUpdatePartyMemberMessage(sbyte type, MapCoordinates coords, double memberId, bool active) : base(type, coords)
		{
			this.memberId = memberId;
			this.active = active;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.memberId = reader.ReadVarUhLong();
			this.active = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.memberId);
			writer.WriteBoolean(this.active);
		}
	}
}