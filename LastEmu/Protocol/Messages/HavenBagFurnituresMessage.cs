using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class HavenBagFurnituresMessage : NetworkMessage
	{
		public const uint Id = 6634;

		public HavenBagFurnitureInformation[] furnituresInfos;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6634;
			}
		}

		public HavenBagFurnituresMessage()
		{
		}

		public HavenBagFurnituresMessage(HavenBagFurnitureInformation[] furnituresInfos)
		{
			this.furnituresInfos = furnituresInfos;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.furnituresInfos = new HavenBagFurnitureInformation[num];
			for (int i = 0; i < num; i++)
			{
				this.furnituresInfos[i] = new HavenBagFurnitureInformation();
				this.furnituresInfos[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.furnituresInfos.Length));
			HavenBagFurnitureInformation[] havenBagFurnitureInformationArray = this.furnituresInfos;
			for (int i = 0; i < (int)havenBagFurnitureInformationArray.Length; i++)
			{
				havenBagFurnitureInformationArray[i].Serialize(writer);
			}
		}
	}
}