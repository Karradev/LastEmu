using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class CompassUpdatePvpSeekMessage : CompassUpdateMessage
	{
		public const uint Id = 6013;

		public double memberId;

		public string memberName;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6013;
			}
		}

		public CompassUpdatePvpSeekMessage()
		{
		}

		public CompassUpdatePvpSeekMessage(sbyte type, MapCoordinates coords, double memberId, string memberName) : base(type, coords)
		{
			this.memberId = memberId;
			this.memberName = memberName;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.memberId = reader.ReadVarUhLong();
			this.memberName = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteVarLong(this.memberId);
			writer.WriteUTF(this.memberName);
		}
	}
}