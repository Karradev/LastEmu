using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildChangeMemberParametersMessage : NetworkMessage
	{
		public const uint Id = 5549;

		public double memberId;

		public uint rank;

		public sbyte experienceGivenPercent;

		public uint rights;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5549;
			}
		}

		public GuildChangeMemberParametersMessage()
		{
		}

		public GuildChangeMemberParametersMessage(double memberId, uint rank, sbyte experienceGivenPercent, uint rights)
		{
			this.memberId = memberId;
			this.rank = rank;
			this.experienceGivenPercent = experienceGivenPercent;
			this.rights = rights;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.memberId = reader.ReadVarUhLong();
			this.rank = reader.ReadVarUhShort();
			this.experienceGivenPercent = reader.ReadSByte();
			this.rights = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.memberId);
			writer.WriteVarShort((int)this.rank);
			writer.WriteSByte(this.experienceGivenPercent);
			writer.WriteVarInt((int)this.rights);
		}
	}
}