using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class UpdateMountBoostMessage : NetworkMessage
	{
		public const uint Id = 6179;

		public int rideId;

		public UpdateMountBoost[] boostToUpdateList;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6179;
			}
		}

		public UpdateMountBoostMessage()
		{
		}

		public UpdateMountBoostMessage(int rideId, UpdateMountBoost[] boostToUpdateList)
		{
			this.rideId = rideId;
			this.boostToUpdateList = boostToUpdateList;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.rideId = reader.ReadVarInt();
			ushort num = reader.ReadUShort();
			this.boostToUpdateList = new UpdateMountBoost[num];
			for (int i = 0; i < num; i++)
			{
				this.boostToUpdateList[i] = ProtocolTypeManager.GetInstance<UpdateMountBoost>(reader.ReadUShort());
				this.boostToUpdateList[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt(this.rideId);
			writer.WriteShort((short)((int)this.boostToUpdateList.Length));
			UpdateMountBoost[] updateMountBoostArray = this.boostToUpdateList;
			for (int i = 0; i < (int)updateMountBoostArray.Length; i++)
			{
				UpdateMountBoost updateMountBoost = updateMountBoostArray[i];
				writer.WriteShort(updateMountBoost.TypeId);
				updateMountBoost.Serialize(writer);
			}
		}
	}
}