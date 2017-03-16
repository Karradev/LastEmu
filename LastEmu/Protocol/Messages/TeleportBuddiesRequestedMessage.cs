using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TeleportBuddiesRequestedMessage : NetworkMessage
	{
		public const uint Id = 6302;

		public uint dungeonId;

		public double inviterId;

		public double[] invalidBuddiesIds;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6302;
			}
		}

		public TeleportBuddiesRequestedMessage()
		{
		}

		public TeleportBuddiesRequestedMessage(uint dungeonId, double inviterId, double[] invalidBuddiesIds)
		{
			this.dungeonId = dungeonId;
			this.inviterId = inviterId;
			this.invalidBuddiesIds = invalidBuddiesIds;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.dungeonId = reader.ReadVarUhShort();
			this.inviterId = reader.ReadVarUhLong();
			ushort num = reader.ReadUShort();
			this.invalidBuddiesIds = new double[num];
			for (int i = 0; i < num; i++)
			{
				this.invalidBuddiesIds[i] = reader.ReadVarUhLong();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.dungeonId);
			writer.WriteVarLong(this.inviterId);
			writer.WriteShort((short)((int)this.invalidBuddiesIds.Length));
			double[] numArray = this.invalidBuddiesIds;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarLong(numArray[i]);
			}
		}
	}
}