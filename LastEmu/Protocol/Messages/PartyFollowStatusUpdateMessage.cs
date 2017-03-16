using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PartyFollowStatusUpdateMessage : AbstractPartyMessage
	{
		public const uint Id = 5581;

		public bool success;

		public bool isFollowed;

		public double followedId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5581;
			}
		}

		public PartyFollowStatusUpdateMessage()
		{
		}

		public PartyFollowStatusUpdateMessage(uint partyId, bool success, bool isFollowed, double followedId) : base(partyId)
		{
			this.success = success;
			this.isFollowed = isFollowed;
			this.followedId = followedId;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			byte num = reader.ReadByte();
			this.success = BooleanByteWrapper.GetFlag(num, 0);
			this.isFollowed = BooleanByteWrapper.GetFlag(num, 1);
			this.followedId = reader.ReadVarUhLong();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.success);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.isFollowed));
			writer.WriteVarLong(this.followedId);
		}
	}
}