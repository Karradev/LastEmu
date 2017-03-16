using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class PrismsListMessage : NetworkMessage
	{
		public const uint Id = 6440;

		public PrismSubareaEmptyInfo[] prisms;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6440;
			}
		}

		public PrismsListMessage()
		{
		}

		public PrismsListMessage(PrismSubareaEmptyInfo[] prisms)
		{
			this.prisms = prisms;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.prisms = new PrismSubareaEmptyInfo[num];
			for (int i = 0; i < num; i++)
			{
				this.prisms[i] = ProtocolTypeManager.GetInstance<PrismSubareaEmptyInfo>(reader.ReadUShort());
				this.prisms[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.prisms.Length));
			PrismSubareaEmptyInfo[] prismSubareaEmptyInfoArray = this.prisms;
			for (int i = 0; i < (int)prismSubareaEmptyInfoArray.Length; i++)
			{
				PrismSubareaEmptyInfo prismSubareaEmptyInfo = prismSubareaEmptyInfoArray[i];
				writer.WriteShort(prismSubareaEmptyInfo.TypeId);
				prismSubareaEmptyInfo.Serialize(writer);
			}
		}
	}
}